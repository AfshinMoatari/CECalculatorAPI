using Amazon.S3.Model;
using Amazon.SimpleEmailV2.Model;
using CEProjectServer.Model;
using CEProjectServer.Model.enums;
using CEProjectServer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static CEProjectServer.Model.enums.InterventionTypeEnum;
using static CEProjectServer.Model.enums.LanguagesEnum;
using static CEProjectServer.Model.enums.OrganisationTypeEnum;
using static CEProjectServer.Model.enums.PopulationTypeEnum;

namespace CEProjectServer.Controllers
{
    [ApiController]
    [Route("api")]
    public class ReportController : Controller
    {
        private readonly IInterventionCalculatorService _interventionCalculatorService;
        private readonly IInterventionPDFUploaderService _interventionPDFUploaderService;
        private readonly IInterventionPDFGeneratorService _interventionPDFGeneratorService;
        private readonly IInterventionAnalyticsService _interventionAnalyticsService;
        private readonly IInterventionEmailSender _interventionEmailSender;
        private readonly IInterventionDownloadService _interventionDownloadService;
        private readonly HttpClient _httpClient;

        public ReportController(IInterventionCalculatorService interventionCalculatorService, IInterventionPDFUploaderService interventionPDFUploaderService, IInterventionPDFGeneratorService interventionPDFGeneratorService, IInterventionAnalyticsService interventionAnalyticsService, IInterventionEmailSender interventionEmailSender, IInterventionDownloadService interventionDownloadService, HttpClient httpClient)
        {
            _interventionCalculatorService = interventionCalculatorService;
            _interventionPDFUploaderService = interventionPDFUploaderService;
            _interventionPDFGeneratorService = interventionPDFGeneratorService;
            _interventionAnalyticsService = interventionAnalyticsService;
            _interventionEmailSender = interventionEmailSender;
            _interventionDownloadService = interventionDownloadService;
            _httpClient = httpClient;
        }

        [HttpGet("report")]
        public async Task<SendEmailResponse> Get(
            [FromQuery] Languages lang,
            [FromQuery] string projectName,
            [FromQuery] string email,
            [FromQuery] int totalParticipant,
            [FromQuery] decimal interventionCosts,
            [FromQuery] PopulationType populationType,
            [FromQuery] InterventionType interventionType,
            [FromQuery] decimal effectScale,
            [FromQuery] OrganisationType organisationType,
            [FromQuery] string organisationName
        )
        {
            var interventionRequestModel = new InterventionRequestModel(
                 projectName,
                 totalParticipant,  
                 interventionCosts,
                 populationType,
                 interventionType,
                 effectScale,
                 organisationType,
                 organisationName
             );
            var analyticId = await _interventionAnalyticsService.DoesUserExistsAsync(email, organisationType, organisationName);
            var reportData = await _interventionCalculatorService.GetReportDataAsync(interventionRequestModel, lang);
            var reportPDFData = await _interventionCalculatorService.GetPDFReportDataAsync(interventionRequestModel, reportData, lang);
            var reportPDFGenerator = await _interventionPDFGeneratorService.GeneratePDFAsync(reportPDFData, analyticId, lang);

           var reportEmailSender = new SendEmailResponse();
            if (reportPDFGenerator)
            {   
                var reportPDFUploader = await _interventionPDFUploaderService.UploadPDFAsync(analyticId);
                var emailSubject = (int)lang == 1 ? "Ensomhed i Tal: Report on the socioeconomic benefits of your intervention" : "Ensomhed i Tal: Rapport på de samfundsøkonomiske gevinster af din intervention";
                reportEmailSender = await _interventionEmailSender.SendEmailAsync(
                    "Ensomhedital Report", email, emailSubject, 
                    new ReportEmailBody(
                        $"https://api.ensomhedital.dk/api/download?id={analyticId}",
                        email,
                        DateTime.UtcNow.AddDays(1).ToString("dd/MM/yyyy"),
                        DateTime.UtcNow.ToString("dd/MM/yyyy")
                        ), lang
                    );
            }

            return reportEmailSender;
        }

        [HttpGet("download")]
        public async Task<ActionResult> Download(
            [FromQuery] string id
        )
        {
            var result = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                var urlRequet = await _interventionDownloadService.DownloadPDF(id);

                if (urlRequet != null)
                {
                    var fileStream = new MemoryStream();
                    using (var file = await _httpClient.GetStreamAsync(urlRequet).ConfigureAwait(false))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    fileStream.Position = 0;

                    var updateAnalytics = await _interventionAnalyticsService.UpdateAnalyticDownloadAsync(id);
                    return File(fileStream, "application/pdf", "ensomhedital.pdf");
                }
                else
                {
                    result.StatusCode = HttpStatusCode.Gone;
                    result.ReasonPhrase = urlRequet;
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.StatusCode = HttpStatusCode.Gone;
                result.ReasonPhrase = ex.Message;
                return Ok(result);
            }
        }

    }
}
