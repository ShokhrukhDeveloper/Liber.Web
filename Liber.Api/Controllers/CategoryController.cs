using Microsoft.AspNetCore.Mvc;

namespace Liber.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}