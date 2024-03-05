namespace Liber.Web.Shared.Auth;

public class Session
{
    public int StudentId { get; set; }
    public string RefreshToken { get; set; }
    public string AccessToken { get; set; }
    public DateTime Expires { get; set; }
}