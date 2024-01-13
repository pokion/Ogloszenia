using OgloszeniaDrobne.Models;

namespace OgloszeniaDrobne.Services.Interfaces
{
    public interface IForbiddenWordsService
    {
        List<ForbiddenWords> GetAll();
        ForbiddenWords GetById(int id);
        List<String> GetAllForbiddenWordsInString(string text);
    }
}
