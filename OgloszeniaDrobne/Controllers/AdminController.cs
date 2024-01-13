using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OgloszeniaDrobne.Models;
using OgloszeniaDrobne.Services.Interfaces;

namespace OgloszeniaDrobne.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICategoryService _category;
        private readonly IForbiddenWordsService _forbiddenWords;
        private readonly IReportedAnnoucment _reportedA;

        public AdminController(ICategoryService category, IForbiddenWordsService forbiddenWords, IReportedAnnoucment reportedA)
        {
            _category = category;
            _forbiddenWords = forbiddenWords;
            _reportedA = reportedA;

        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Category()
        {
            ViewData["Categories"] = _category.GetSortedCategories();
            ViewData["CategoriesNotSorted"] = _category.GetAll();
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ForbiddenWords()
        {
            ViewData["ForbiddenWords"] = _forbiddenWords.GetAll();
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ReportedAnnoucments()
        {
            ViewData["ReportedAnnoucments"] = _reportedA.GetAll();
            return View();
        }

    }
}
