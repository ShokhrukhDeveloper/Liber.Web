using Liber.Api.Constants;

namespace Liber.Api.Services;

public interface IJWTService
{
    string GenerateToken(JWTConst calims);
    JWTConst? Authenticate (HttpContext httpContext);
}