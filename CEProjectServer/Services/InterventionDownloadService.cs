using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using CEProjectServer.Data;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Net;
using Amazon.SimpleEmailV2.Model;
using System.Net.Http.Headers;

namespace CEProjectServer.Services
{
    public interface IInterventionDownloadService
    {
        Task<string> DownloadPDF(string id);
    }

    public class InterventionDownloadService : IInterventionDownloadService
    {
        private readonly CEContext _context;
        private readonly HttpClient _httpClient;

        public InterventionDownloadService(CEContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;
        }

        public async Task<string> DownloadPDF(string id)
        {
            var guid = new Guid(id);
            var response = await _context.Analytics.Where(x => x.Id == guid).ToListAsync();

            if (response != null && response.Count() > 0)
            {
                var user = response.FirstOrDefault();
                var presignedURL = user.DownloadURL;

                HttpResponseMessage checkURL = await _httpClient.GetAsync(presignedURL, HttpCompletionOption.ResponseHeadersRead);

                if (checkURL.StatusCode == HttpStatusCode.Forbidden) {
                    return "Filen er udløbet, anmod venligst om den igen.";
                }
                else
                {
                    return presignedURL;
                }
            }
            return "Ingen sådan fil fundet!";
        }
    }
}
