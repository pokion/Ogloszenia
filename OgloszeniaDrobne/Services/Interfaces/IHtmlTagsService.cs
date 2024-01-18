using OgloszeniaDrobne.Models;

namespace OgloszeniaDrobne.Services.Interfaces
{
    public interface IHtmlTagsService
    {
        List<HtmlTags> GetAll();
        List<string> GetListOfForbiddenTags(string text);
    }
}
