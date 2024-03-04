namespace Liber.Api.Entities;

public class SubCategory : EntityBase
{
    public int category_id { get; set; }
    public virtual Category? Category { get; set; }
    public virtual ICollection<Book>? Books { get; set; }
    public string name { get; set; }
    public string? image { get; set; }
}