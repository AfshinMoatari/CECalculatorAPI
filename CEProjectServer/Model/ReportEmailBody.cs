namespace CEProjectServer;

public class ReportEmailBody
{
    public string DocumentURL { get; set; }
    public string RecipientEmail { get; set; }
    public string ExpirationDate { get; set; }
    public string CreationDate { get; set; }

    public ReportEmailBody(string documentURL, string recipientEmail, string expirationDate, string creationDate)
    {
        DocumentURL = documentURL;
        RecipientEmail = recipientEmail;
        ExpirationDate = expirationDate;
        CreationDate = creationDate;
    }

    public ReportEmailBody()
    {}
}
