using Liber.Web.Shared.Category;

namespace Liber.Web.Services;

public interface ICategoryService
{
    Task<IEnumerable<Category>>GetAllCategoriesAsync();
}