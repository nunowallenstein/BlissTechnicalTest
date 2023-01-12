using System.ComponentModel.DataAnnotations;

namespace BlissQuestions.API.Models
{
    public class ShareContentDto
    {
        [Required]
        public string DestinationEmail { get; set; }
        [Required]
        public string ContentUrl { get; set; }
    }
}
