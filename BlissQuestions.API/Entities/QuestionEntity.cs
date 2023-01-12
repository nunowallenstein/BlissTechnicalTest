using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlissQuestions.API.Entities
{
    public class QuestionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public string? ImageUrl { get; set; }
        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public string? ThumbUrl { get; set; }

        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public string? Question { get; set; }
        [Required (ErrorMessage = "Bad request. All fields are mandatory")]
        public DateTime PublishedAt { get; set; }
        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public ICollection<ChoiceEntity> Choices { get; set; } = new List<ChoiceEntity>();

    }
}
