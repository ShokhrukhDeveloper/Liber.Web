using Liber.Web.Shared.Auth;

namespace Liber.Api.Services;

public interface IAuthService
{
    ValueTask<Result<Entities.Session>> LogIn(Login login);
    ValueTask<Result<Entities.Session>> ChangePassword(PasswordChange password);
    ValueTask<Result<Entities.User>> GetUserDataById(int Id);
    ValueTask<Result<Entities.Session>> LogOut(int UserId, string accessToken);
    ValueTask<Result<List<Entities.Session>>> GetsSessionsById(int id);
    ValueTask<Result<Entities.Session>> DeleteSessionById(int StudentId,int SessionId);
}