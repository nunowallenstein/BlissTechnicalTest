using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlissQuestions.API.Entities
{
    public class ChoiceEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Choice { get; set; }

        [Required]
        public int Votes { get; set; }

        [ForeignKey("QuestionId")]
        public QuestionEntity? Question { get; set; }

        public int QuestionId { get; set; }
    }
}
