using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using PCCC.Service.Interfaces;
using PCCC.Common.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace PCCC.API.Controllers.Web
{
    [Route("api/web/[controller]")]
    [ApiExplorerSettings(GroupName = "Web")]
    [ApiController]
    [SwaggerTag("Authen")]
    public class AuthenticationController : ControllerBase
    {
        public IConfiguration _Configuration;
        private readonly IUserService _userService;
        private readonly string secretKey;
        private readonly int timeout;
        public AuthenticationController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _Configuration = configuration;
            try
            {
                secretKey = _Configuration["AppSettings:Secret"];
                timeout = int.Parse(_Configuration["Time:timeout"]);
            }
            catch
            {
                secretKey = String.Empty;
                timeout = 5;
            }
        }
        //[HttpPost("Login")]
        //public async Task<JsonResultModel> Login(LoginModel model)
        //{
        //    return await _userService.Authenticate(model, secretKey, timeout);
        //}
       
    }
}
