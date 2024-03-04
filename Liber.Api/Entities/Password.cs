namespace Liber.Api.Entities;

public class Password : EntityBase
{
    public string Login { get; set; }
    public int StudentId { get; set; }
    public virtual User? User { get; set; }

    public string PasswordHash { get; set; }
}