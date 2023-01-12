using BlissQuestions.API.Models;
using System.Threading.Tasks;

namespace BlissQuestions.API.Services
{
    public interface IEmailService
    {
        Task ShareContent(ShareContentDto shareContent);
    }
}
