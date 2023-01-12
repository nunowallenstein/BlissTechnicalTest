using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BlissQuestions.API.Models
{
    public class QuestionForCreationDto
    {
        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public string? ImageUrl { get; set; }
        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public string? ThumbUrl { get; set; }

        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public string? Question { get; set; }
        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public DateTime PublishedAt { get; set; }
        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public ICollection<ChoiceDto> Choices { get; set; } = new List<ChoiceDto>();

    }
}
