using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rekabet_login.Domain.Models;
using Rekabet_login.Responses;
using Rekabet_login.Security.Token;

namespace Rekabet_login.Domain.Services
{
    public interface IAuthenticationService
    {
        BaseResponse<AccessToken> CreateAccessToken(string email, string password);

        BaseResponse<AccessToken> CreateAccessTokenByRefreshToken(string refreshToken);

        BaseResponse<AccessToken> RevokeRefreshToken(string refreshToken);
    }
}
