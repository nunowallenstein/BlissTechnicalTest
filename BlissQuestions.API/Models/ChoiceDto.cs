using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlissQuestions.API.Models
{
    public class ChoiceDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        public string? Choice { get; set; }

        [Required(ErrorMessage = "You should provide the number of votes for the choiceue.")]
        public int Votes { get; set; }
    }
}
