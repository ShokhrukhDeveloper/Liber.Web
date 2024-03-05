using Liber.Api.Entities;
using Liber.Web.Shared.Auth;
using Session = Liber.Api.Entities.Session;

namespace Liber.Api.Services;

public class AuthService : IAuthService
{
    public ValueTask<Result<Session>> LogIn(Login login)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result<Session>> ChangePassword(PasswordChange password)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result<User>> GetUserDataById(int Id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result<Session>> LogOut(int UserId, string accessToken)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result<List<Session>>> GetsSessionsById(int id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result<Session>> DeleteSessionById(int StudentId, int SessionId)
    {
        throw new NotImplementedException();
    }
}