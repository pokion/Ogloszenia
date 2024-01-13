using OgloszeniaDrobne.Services.Interfaces;
using OgloszeniaDrobne.Models;

namespace OgloszeniaDrobne.Services
{
    public class AnnoucmentsService : IAnnoucmentsService
    {
        private readonly DBContext _context;
        public AnnoucmentsService(DBContext context)
        { 
            _context = context;
        }
        public List<Announcement> GetAll()
        {
            return _context.Announcements.ToList();
        }
        public Announcement Get(int id)
        {
            return _context.Announcements.Find(id);
        }
        public PaginAnnoucmentModel GetPagin(int page)
        {
            var paginModel = new PaginAnnoucmentModel();
            paginModel.Data = _context.Announcements.OrderBy(a => a.CreateDate).Skip(page * 10).Take(10).ToList();
            paginModel.Page = page++;
            paginModel.Total = _context.Announcements.Count() / 10;
            return paginModel;
        }
    }
}
