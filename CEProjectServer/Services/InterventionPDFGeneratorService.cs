using CEProjectServer.Model.enums;
using CEProjectServer.Renderers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PuppeteerSharp;
using static CEProjectServer.Model.enums.LanguagesEnum;

namespace CEProjectServer.Services
{
    public interface IInterventionPDFGeneratorService
    {
        Task<bool> GeneratePDFAsync(ReportPDFData reportPDFData, string analyticId, Languages lang);
    }

    public class InterventionPDFGeneratorService : PageModel, IInterventionPDFGeneratorService
    {
        private readonly IRazorTemplateRenderer _renderer;

        public InterventionPDFGeneratorService(IRazorTemplateRenderer renderer)
        {
            _renderer = renderer;
        }
        public ReportPDFData ReportPDFData { get; set; } = new ();

        public async Task<bool> GeneratePDFAsync(ReportPDFData reportPDFData, string analyticId, Languages lang)
        {
                ReportPDFData = reportPDFData;
                var reportTemplateName = (int)lang == 1 ? "_CEReport-chrome-en-new" : "_CEReport-chrome-dk-new";
                var appendixTemplateName = (int)lang == 1 ? "_CEReport-appendix-chrome-en" : "_CEReport-appendix-chrome-dk";
                var reportHTML = await _renderer.RenderPartialToStringAsync(reportTemplateName, this);
                var appendixHTML = await _renderer.RenderPartialToStringAsync(appendixTemplateName, this);

                var baseDirectory = Directory.GetCurrentDirectory();
                string tempDirectory = Path.Combine(baseDirectory, "Pod");
                var outputFile = Path.Combine(tempDirectory, $"{analyticId}.pdf");
                var reportOutputFile = Path.Combine(tempDirectory, $"{analyticId}-report.pdf");
                var appendixOutputFile = Path.Combine(tempDirectory, $"{analyticId}-appendix.pdf");

                var pdfOptions = new PdfOptions();
                pdfOptions.Width = "880px";
                pdfOptions.Height = "1280px";
                pdfOptions.PrintBackground = true;

                // using local chrome rather than downloading/checking on every excecution
                //using var browserFetcher = new BrowserFetcher();
                //await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);

                using (var browser = await Puppeteer.LaunchAsync(new LaunchOptions
                {
                    Headless = true,
                    ExecutablePath = baseDirectory + "\\Chrome\\chrome.exe"
                }))
                {
                    using (var page = await browser.NewPageAsync())
                    {
                        await page.SetContentAsync(reportHTML);
                        await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "\\Views\\pdf-styles.css" });
                        await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                        await page.PdfAsync(reportOutputFile, pdfOptions);
                    }
                    using (var page = await browser.NewPageAsync())
                    {
                        await page.SetContentAsync(appendixHTML);
                        await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "\\Views\\pdf-styles.css" });
                        await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                        await page.PdfAsync(appendixOutputFile, pdfOptions);
                    }
                }

                using (PdfDocument one = PdfReader.Open(reportOutputFile, PdfDocumentOpenMode.Import))
                using (PdfDocument two = PdfReader.Open(appendixOutputFile, PdfDocumentOpenMode.Import))
                using (PdfDocument outPdf = new PdfDocument())
                {
                    CopyPages(one, outPdf);
                    CopyPages(two, outPdf);

                    outPdf.Save(outputFile);
                }

                void CopyPages(PdfDocument from, PdfDocument to)
                {
                    for (int i = 0; i < from.PageCount; i++)
                    {
                        to.AddPage(from.Pages[i]);
                    }
                }

                if (Directory.GetFiles(tempDirectory, $"{analyticId}.pdf").Length == 0)
                {
                    return false;
                }
            return true;
        }
    }
}
