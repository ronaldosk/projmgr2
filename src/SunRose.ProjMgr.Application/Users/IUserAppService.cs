using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SunRose.ProjMgr.Roles.Dto;
using SunRose.ProjMgr.Users.Dto;

namespace SunRose.ProjMgr.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
