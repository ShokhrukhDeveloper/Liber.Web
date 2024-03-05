using Liber.Web.Services;
using Liber.Web.Shared.Category;
using Microsoft.AspNetCore.Components;

namespace Liber.Web.Pages;

public partial class SubCategoryPage
{
    [Inject]
    public ISubCategoryService SubCategoryService { get; set; }
    [Parameter]
    public string id { get; set; }
    private List<SubCategory> subCategoriesList { get; set; }
    protected override async Task OnInitializedAsync()
    {
        subCategoriesList = (await SubCategoryService.GetAllSubcategoryByCategoryIdAsync(id)).ToList();
    }

    protected override async Task OnParametersSetAsync()
    {
        subCategoriesList = (await SubCategoryService.GetAllSubcategoryByCategoryIdAsync(id)).ToList();
    }
}