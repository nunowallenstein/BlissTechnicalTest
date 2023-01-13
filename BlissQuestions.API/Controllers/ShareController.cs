using BlissQuestions.API.Models;
using BlissQuestions.API.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace BlissQuestions.API.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/share")]
    [ApiController]
    public class ShareController : ControllerBase
    {
        private readonly IEmailService _emailService;
      public ShareController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<ActionResult<StatusDto>> ShareContent(
            [FromQuery(Name = "destination_email")] string? destinationEmail,
            [FromQuery(Name = "content_url")] string? contentUrl)
        {
            if (destinationEmail == null || contentUrl == null)
            {
                return BadRequest(new StatusDto() { Status = "Bad Request. Either destination_email not valid or empty content_url" });
            }
            var shareContent = new ShareContentDto()
            {
                ContentUrl = contentUrl,
                DestinationEmail = destinationEmail,
            };

            await _emailService.SendEmail(shareContent);

            return Ok(new StatusDto() { Status="OK"});
        }

    }
}
