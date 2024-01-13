namespace OgloszeniaDrobne.Models
{
    public class PaginAnnoucmentModel
    {
        public int Page { get; set; }
        public int Total { get; set; }
        public List<Announcement> Data { get; set; }
    }
}
