using Rekabet_login.Domain.Models;


namespace Rekabet_login.Security.Token
{
    public interface ITokenHandler
    {
        AccessToken CreateAccessToken(User user);

        void RevokeRefreshToken(User user);
    }
}