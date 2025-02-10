using Amazon.S3;
using Amazon.S3.Model;

namespace CEProjectServer.Services
{
    public interface IInterventionPDFUploaderService
    {
        Task<string> UploadPDFAsync(string analyticId);
    }

    public class InterventionPDFUploaderService : IInterventionPDFUploaderService
    {
        private readonly IAmazonS3 _s3Client;
        private readonly IInterventionAnalyticsService _interventionAnalyticsService;
        private readonly string _bucketName = "ce-intervention-report-pdfpod";

        public InterventionPDFUploaderService(IAmazonS3 s3Client, IInterventionAnalyticsService interventionAnalyticsService)
        {
            _s3Client = s3Client;
            _interventionAnalyticsService = interventionAnalyticsService;
        }

        public async Task<string> UploadPDFAsync(string analyticId)
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Pod");
            var filePath = Path.Combine(folderPath, $"{analyticId}.pdf");
            FileInfo file = new FileInfo(filePath);

            PutObjectRequest request = new PutObjectRequest()
            {
                InputStream = file.OpenRead(),
                BucketName = _bucketName,
                Key = file.Name
            };
            request.Metadata.Add("Content-Type", "application/pdf");

            string url = "";
            var response = await _s3Client.PutObjectAsync(request);
            if (response.HttpStatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                url = GetPreSignedUrl(analyticId);
                var creationDate = DateTime.UtcNow;
                var analyticResponse = await _interventionAnalyticsService.UpdateAnalyticURLAsync(analyticId, creationDate, creationDate.AddDays(1), url);

                if(analyticResponse)
                {
                    DisposeTempFiles(analyticId);
                }
            }

            return url;
        }

        public string GetPreSignedUrl(string analyticId)
        {
            GetPreSignedUrlRequest urlRequest = new GetPreSignedUrlRequest
            {
                BucketName = _bucketName,
                Key = $"{analyticId}.pdf",
                Expires = DateTime.Now.AddDays(7)
            };
            return _s3Client.GetPreSignedURL(urlRequest);
        }

        public void DisposeTempFiles(string analyticId)
        {
            string baseDirectory = Environment.CurrentDirectory;
            string tempDirectory = baseDirectory + "\\Pod\\";
            var outputFile = Path.Combine(tempDirectory, $"{analyticId}.pdf");
            var reportOutputFile = Path.Combine(tempDirectory, $"{analyticId}-report.pdf");
            var appendixOutputFile = Path.Combine(tempDirectory, $"{analyticId}-appendix.pdf");
            var outputFileInfo = new FileInfo(appendixOutputFile);
            var reportFileInfo = new FileInfo(reportOutputFile);
            var appendixFileInfo = new FileInfo(outputFile);

            if (outputFileInfo.Exists)
            {
                outputFileInfo.Delete();
                if (reportFileInfo.Exists)
                {
                    reportFileInfo.Delete();
                }
                if (appendixFileInfo.Exists)
                {
                    appendixFileInfo.Delete();
                }
            }

            int count = Directory.EnumerateFiles(tempDirectory).Count();
            if (count >= 10000)
            {
                foreach (FileInfo file in new DirectoryInfo(tempDirectory).GetFiles())
                {
                    file.Delete();
                }
            }
        }
    }
}
