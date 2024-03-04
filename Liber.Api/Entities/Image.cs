namespace Liber.Api.Entities;

public class Image : EntityBase
{
    public ulong Id { get; set; }
    public int? BookId { get; set; }
    public virtual Book? Book { get; set; }
    public string? Url { get; set; }
}