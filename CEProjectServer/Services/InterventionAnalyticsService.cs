using CEProjectServer.Data;
using Microsoft.EntityFrameworkCore;
using static CEProjectServer.Model.enums.OrganisationTypeEnum;

namespace CEProjectServer.Services
{
    public interface IInterventionAnalyticsService
    {
        Task<string> DoesUserExistsAsync(string email, OrganisationType organisationType, string organisationName);
        Task<bool> UpdateAnalyticURLAsync(string id, DateTime creationDate, DateTime expirationDate, string downloadURL);
        Task<bool> UpdateAnalyticDownloadAsync(string id);
    }

    public class InterventionAnalyticsService : IInterventionAnalyticsService
    {
        private readonly CEContext _context;

        public InterventionAnalyticsService(CEContext context)
        {
            _context = context;
        }

        public async Task<string> DoesUserExistsAsync(string email, OrganisationType organisationType, string organisationName)
        {
            var response = await _context.Analytics.Where(x => x.Email == email).ToListAsync();

            if (response != null && response.Count() > 0)
            {
                var updatedAnalytic = response.FirstOrDefault();
                updatedAnalytic.OrganisationName = organisationName;
                updatedAnalytic.OrganisationType = (int)organisationType;
                updatedAnalytic.CreationCount += 1;
                _context.Entry(updatedAnalytic).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return response.FirstOrDefault().Id.ToString();
            }
            else
            {
                var newAnalytic = new AnalyticModel(
                    Guid.NewGuid(),
                    email,
                    organisationName,
                    (int)organisationType,
                    1);
                _context.Analytics.Add(newAnalytic);
                await _context.SaveChangesAsync();
                return newAnalytic.Id.ToString();
            }
        }

        public async Task<bool> UpdateAnalyticURLAsync(string id, DateTime creationDate, DateTime expirationDate, string downloadURL)
        {
            var response = await _context.Analytics.Where(x => x.Id == new Guid(id)).ToListAsync();
            var updatedAnalytic = response.FirstOrDefault();
            updatedAnalytic.CreatedAt = creationDate;
            updatedAnalytic.ExpirationDate = expirationDate;
            updatedAnalytic.DownloadURL = downloadURL;
            _context.Entry(updatedAnalytic).State = EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            return result.Equals(0) ? false : true;
        }

        public async Task<bool> UpdateAnalyticDownloadAsync(string id)
        {
            var response = await _context.Analytics.Where(x => x.Id == new Guid(id)).ToListAsync();
            var updatedAnalytic = response.FirstOrDefault();
            updatedAnalytic.Downloads += 1;
            updatedAnalytic.LatestDownload = DateTime.UtcNow;
            _context.Entry(updatedAnalytic).State = EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            return result.Equals(0) ? false : true;
        }
    }
}
