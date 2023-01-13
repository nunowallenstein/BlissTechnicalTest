using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlissQuestions.API.Models
{
    public class ChoiceDto
    {
        public string? Choice { get; set; }
        public int Votes { get; set; }
    }
}
