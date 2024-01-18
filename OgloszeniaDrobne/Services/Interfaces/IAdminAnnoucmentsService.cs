using OgloszeniaDrobne.Models;

namespace OgloszeniaDrobne.Services.Interfaces
{
    public interface IAdminAnnoucmentsService
    {
        List<AdminAnnoucments> GetAll();
        void Create(AdminAnnoucments annoucment);
        void Delete(AdminAnnoucments annoucment);
    }
}
