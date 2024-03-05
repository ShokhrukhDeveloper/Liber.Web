using Liber.Web.Pages;
using Liber.Web.Shared.Category;

namespace Liber.Web.Services;

public interface ISubCategoryService
{
    Task<IEnumerable<SubCategory>> GetAllSubcategoryByCategoryIdAsync(string id);
}