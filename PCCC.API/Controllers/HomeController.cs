using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PCCC.Data.Entities;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace PCCC.API.Controllers
{
    internal sealed class LoginImpl(
    IHttpContextAccessor http,
    ILogger<LoginImpl> logger,
    IQueryRepository repository
) : ILoginService
    [HttpPost]
    [Route("api/[controller]/login")]
    public async Task<bool> LoginAsync(UserModel model)
    {
        try
        {
            var user = await repository.GetAsync<User>(x => x.UserName == model.UserName, true);

            if (user is null)
            {
                return false;
            }

            if (!await SecretHasher.VerifyAsync(model.Password, user.Password))
            {
                return false;
            }

            await http.HttpContext.AuthenticateAsync();
            await http.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                CreateUserClaims(user),
                new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddHours(24),
                    IsPersistent = true,
                    IssuedUtc = DateTimeOffset.UtcNow
                }
            );
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError("Some thing wrong {}", ex.Message);
            return false;
        }
    }
}
