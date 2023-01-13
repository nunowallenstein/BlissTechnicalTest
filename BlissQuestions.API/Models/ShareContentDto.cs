using System.ComponentModel.DataAnnotations;

namespace BlissQuestions.API.Models
{
    public class ShareContentDto
    {
        public string? DestinationEmail { get; set; }

        public string? ContentUrl { get; set; }
    }
}
