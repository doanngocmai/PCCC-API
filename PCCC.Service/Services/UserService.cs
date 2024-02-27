using System.Text;
using System.Security.Claims;
using PCCC.Common.DTOs;
using PCCC.Common.Utils;
using AutoMapper;
using PCCC.Common.Models.Authentication;
using PCCC.Service.Interfaces;
using APIProject.Repository.Interfaces;

namespace PCCC.Service.Services
{
    public class UserService : BaseService<PCCC.Data.Entities.User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        
        public async Task<JsonResultModel> Authenticate(LoginModel model, string secretKey, int timeout)
        {
            try
            {
                if (model.Phone == null || model.Password == null)
                    return JsonResponse.Error(PCCCConsts.ERROR_LOGIN_FIELDS_INVALID, PCCCConsts.MESSAGE_LOGIN_FIELDS_INVALID);
                return JsonResponse.Success();
            }
            catch (Exception ex)
            {
                return JsonResponse.ServerError();
            }
        }

    }
}
