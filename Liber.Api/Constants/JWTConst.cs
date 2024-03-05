namespace Liber.Api.Constants;

public class JWTConst
{
    public JWTConst()
    {
    
    }
    public JWTConst(int Id,string Role)
    {
        this.Id=Id;
        this.Role=Role;
    }
    public int Id { get; set; }  
    public string? Role { get; set; }  
}