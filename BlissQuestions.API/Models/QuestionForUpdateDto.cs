using System.Collections.Generic;
using System;

namespace BlissQuestions.API.Models
{
    public class QuestionForUpdateDto
    {
        public string? ImageUrl { get; set; }
        public string? ThumbUrl { get; set; }
        public string? Question { get; set; }

        public DateTime PublishedAt { get; set; }
        public ICollection<ChoiceDto> Choices { get; set; } = new List<ChoiceDto>();

    }
}
