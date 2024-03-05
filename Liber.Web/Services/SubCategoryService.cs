using System.Net.Http.Json;
using Liber.Web.Shared.Category;

namespace Liber.Web.Services;

public class SubCategoryService : ISubCategoryService
{
    private readonly HttpClient httpClient;
    public SubCategoryService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<IEnumerable<SubCategory>> GetAllSubcategoryByCategoryIdAsync(string id)
    {
        var response = await httpClient.GetFromJsonAsync<IEnumerable<SubCategory>>($"/Category/{id}/Subjects");
        return response;
    }
}