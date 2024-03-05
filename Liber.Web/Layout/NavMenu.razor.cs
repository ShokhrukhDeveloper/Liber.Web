using Liber.Web.Services;
using Liber.Web.Shared.Category;
using Microsoft.AspNetCore.Components;

namespace Liber.Web.Layout;

public partial class NavMenu
{
    [Inject]
    public ICategoryService CategoryService { get; set; }

    private List<Category> CategoriesList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        CategoriesList = (await CategoryService.GetAllCategoriesAsync()).ToList();
    }
}