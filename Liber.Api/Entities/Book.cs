namespace Liber.Api.Entities;

public class Book : EntityBase
{
    public string? Description { get; set; }
    public string Name { get; set; }
    public string CaseSensitive { get; set; }
    public int? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
    public int? SubjectId { get; set; }
    public virtual SubCategory? SubCategory { get; set; }
    public int UserId { get; set; }
    public virtual User? User { get; set; }
    public int? LanguageId { get; set; }
    public virtual Language? Language { get; set; }
    public virtual ICollection<Image>? Images { get; set; }
    public string FileType { get; set; } 
    public string FilePath { get; set; }
    public long FileSize { get; set; }
    public bool IsAccepted { get; set; }
    public string? Image { get; set; }
    public int Views { get; set; }
    public string? Keywords { get; set; }
    public int Downloads { get; set; }
    public decimal Price { get; set; }=0.0m;
}