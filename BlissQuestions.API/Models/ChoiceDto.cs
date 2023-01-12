using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlissQuestions.API.Models
{
    public class ChoiceDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Choice { get; set; }

        [Required]
        public int Votes { get; set; }

        [ForeignKey("QuestionId")]
        public QuestionDto? Question {get;set;}

        public int QuestionId { get; set; }
    }
}
