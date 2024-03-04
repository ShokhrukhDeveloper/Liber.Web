namespace Liber.Api.Entities;

public class User : EntityBase
{
    public virtual ICollection<Book>? Books { get; set; }
    public virtual  ICollection<Session>? Sessions { get; set; }
    public virtual Password? Password { get; set; }
    public string? Email { get; set; }
    public ERoles Role { get; set; }=ERoles.User;
    public decimal Balance { get; set; }
    public string? FullName { get; set; }
    public string? Image { get; set; }
    public string Phone { get; set; }
    public bool IsBlocked { get; set; }
    public DateOnly? Birthday { get; set; }
}