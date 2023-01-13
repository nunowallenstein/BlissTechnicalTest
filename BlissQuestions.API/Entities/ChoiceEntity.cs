using BlissQuestions.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlissQuestions.API.Entities
{
    public class ChoiceEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Choice { get; set; }
        public int Votes { get; set; }

        [ForeignKey("QuestionId")]
        public QuestionEntity? Question { get; set; }

        public int QuestionId { get; set; }
    }
}
