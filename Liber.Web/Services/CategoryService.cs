using System.Net.Http.Json;
using System.Text.Json;
using Liber.Web.Shared.Category;

namespace Liber.Web.Services;

public class CategoryService : ICategoryService
{
    private readonly HttpClient httpClient;
    public CategoryService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        var response = await httpClient.GetFromJsonAsync<IEnumerable<Category>>("/Category");
        return response;
       // var e = await  JsonSerializer.DeserializeAsync<IEnumerable<Category>>(response, new JsonSerializerOptions() { PropertyNameCaseInsensitive=true});
      //return e;
    }
}