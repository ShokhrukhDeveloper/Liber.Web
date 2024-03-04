namespace Liber.Api.Entities;

public class Category : EntityBase
{
    public string Name { get; set; }
    public string? Image { get; set; }
    public virtual ICollection<SubCategory>? SubCategories { get; set; }
    public virtual ICollection<Book>? Books { get; set; }
    
}