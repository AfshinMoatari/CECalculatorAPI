using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;
using CEProjectServer.Model.enums;
using CEProjectServer.Renderers;
using static CEProjectServer.Model.enums.LanguagesEnum;

namespace CEProjectServer.Services
{
    public interface IInterventionEmailSender
    {
        Task<SendEmailResponse> SendEmailAsync(string sender, string receiver, string subject, ReportEmailBody reportEmailBody, Languages lang);
    }

    public class InterventionEmailSender : IInterventionEmailSender
    {
        private const string senderAddress = "{{}} <noreply@ensomhedital.dk>";
        private readonly IAmazonSimpleEmailServiceV2 _emailService;
        private readonly IRazorTemplateRenderer _renderer;

        public InterventionEmailSender(IRazorTemplateRenderer renderer, IAmazonSimpleEmailServiceV2 emailService)
        {
            _renderer = renderer;
            _emailService = emailService;
        }
        public ReportEmailBody ReportEmailBody { get; set; } = new();

        public async Task<SendEmailResponse> SendEmailAsync(string sender, string receiver, string subject, ReportEmailBody reportEmailBody, Languages lang)
        {
            ReportEmailBody = reportEmailBody;
            var templateName = (int)lang == 1 ? "_CEEmail-en" : "_CEEmail-dk";
            var body = await _renderer.RenderPartialToStringAsync(templateName, this);
            var base64Name = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(sender));

            var response = await _emailService.SendEmailAsync(new SendEmailRequest
            {
                FromEmailAddress = senderAddress.Replace("{{}}", $"=?UTF-8?B?{base64Name}?="),
                Destination = new Destination { ToAddresses = { receiver } },
                Content = new EmailContent
                {
                    Simple = new Message
                    {
                        Subject = new Content
                        {
                            Charset = "UTF-8",
                            Data = subject
                        },
                        Body = new Body
                        {
                            Html = new Content
                            {
                                Charset = "UTF-8",
                                Data = body
                            }
                        }
                    }
                }
            });

            return response;
        }
    }
}
