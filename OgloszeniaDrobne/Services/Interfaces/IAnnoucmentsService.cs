using OgloszeniaDrobne.Models;

namespace OgloszeniaDrobne.Services.Interfaces
{
    public interface IAnnoucmentsService
    {
        List<Announcement> GetAll();
        Announcement Get(int id);
        PaginAnnoucmentModel GetPagin(int page);
    }
}
