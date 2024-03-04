namespace Liber.Api.Entities;

public class Language : EntityBase
{
    public virtual ICollection<Book>? Books { get; set; }
    public string? Name { get; set; }
}