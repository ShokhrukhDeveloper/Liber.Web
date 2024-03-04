namespace Liber.Api.Entities;

public class SubCategory : EntityBase
{
    public int StudentId { get; set; }
    public virtual User? User { get; set; }
    public string RefreshToken { get; set; }
    public string AccessToken { get; set; }
    public DateTime? Expires { get; set; }
}