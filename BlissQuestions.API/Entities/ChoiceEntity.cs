using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlissQuestions.API.Entities
{
    public class ChoiceEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public string? Choice { get; set; }

        [Required(ErrorMessage = "Bad request. All fields are mandatory")]
        public int Votes { get; set; }

        [ForeignKey("QuestionId")]
        public QuestionEntity? Question { get; set; }

        public int QuestionId { get; set; }
    }
}
