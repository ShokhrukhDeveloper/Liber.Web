using System.ComponentModel.DataAnnotations;
using Microsoft;
namespace Liber.Web.Shared.Book;

public class NewBook
{
    [Required,MinLength(3)]
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Keyword { get; set; }=null;
    [Range(0,int.MaxValue)]
    public int SubjectId { get; set; }
    public decimal Price { get; set; }=0.0m;
    public int NumberOfScreenshots { get; set; }=5;
    public int? LanguageId { get; set; } = 1;
   // public IFormFile File { get; set; }
}