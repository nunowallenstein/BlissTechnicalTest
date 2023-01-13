using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BlissQuestions.API.Models
{
    public class QuestionForCreationDto
    {
        public string? ImageUrl { get; set; }
        public string? ThumbUrl { get; set; }
        public string? Question { get; set; }

        public DateTime PublishedAt { get; set; }
        public ICollection<string> Choices { get; set; } = new List<string>();

    }
}
