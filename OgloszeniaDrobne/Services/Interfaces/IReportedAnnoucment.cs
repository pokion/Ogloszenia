using OgloszeniaDrobne.Models;

namespace OgloszeniaDrobne.Services.Interfaces
{
    public interface IReportedAnnoucment
    {
        List<ReportedAnnoucmentModel> GetAll();
        void RemovePost(ReportedAnnoucmentModel reportedAnnoucment);
        void RemoveReport(ReportedAnnoucmentModel reportedAnnoucment);
    }
}
