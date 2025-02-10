using System.ComponentModel.DataAnnotations;

namespace CEProjectServer;

    public class AnalyticModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string OrganisationName { get; set; }
        public int OrganisationType { get; set; }
        public int Downloads { get; set; }
        public int CreationCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime LatestDownload { get; set; }
        public string? DownloadURL { get; set; }

        public AnalyticModel(Guid id, string email, string organisationName, int organisationType, int creationCount)
        {
            Id = id;
            Email = email;
            OrganisationName = organisationName;
            OrganisationType = organisationType;
            CreationCount = creationCount;
        }

        public AnalyticModel(DateTime createdAt, DateTime expirationDate, string downloadURL)
        {
            CreatedAt = createdAt;
            ExpirationDate = expirationDate;
            DownloadURL = downloadURL;
        }
    }

