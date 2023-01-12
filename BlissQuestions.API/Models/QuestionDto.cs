using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlissQuestions.API.Models
{
    public class QuestionDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? ImageUrl { get; set; }

        public string? ThumbUrl { get; set; }

        [Required]
        public string? Question { get; set; }

        public DateTime PublishedAt { get; set; }

        public ICollection<ChoiceDto> Choices { get; set; } = new List<ChoiceDto>();

    }
}
