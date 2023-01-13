using BlissQuestions.API.Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BlissQuestions.API.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<IEmailService> _logger;
        public EmailService(ILogger<IEmailService> logger)
        {
            _logger = logger;
        }
        public async Task SendEmail(ShareContentDto shareContent)
        {
            _logger.LogInformation($"The content url {shareContent.ContentUrl} will be sent to the following email:{shareContent.DestinationEmail}");
            await Task.Delay(2000); //simulation of the email being sent
            _logger.LogInformation($"The content was successfully sent");
        }


    }
}
