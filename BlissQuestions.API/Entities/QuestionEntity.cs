using BlissQuestions.API.Models;
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
        public string? ImageUrl { get; set; }
        public string? ThumbUrl { get; set; }
        public string? Question { get; set; }
        public DateTime PublishedAt { get; set; }
        public ICollection<ChoiceEntity> Choices { get; set; } = new List<ChoiceEntity>();

    }
}
