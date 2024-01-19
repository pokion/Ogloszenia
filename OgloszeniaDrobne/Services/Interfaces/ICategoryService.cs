using OgloszeniaDrobne.Models;
namespace OgloszeniaDrobne.Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<CategoryChilds> GetSortedCategories();
        Category GetCategoryById(int id);
        Category Create(Category category);
        Task<int> LinkCategoriesToAnnounments(int annoucmentId, string[] categoriesIds);
    }
}
