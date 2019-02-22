using System.Threading.Tasks;
using Abp.Application.Services;
using SunRose.ProjMgr.Authorization.Accounts.Dto;

namespace SunRose.ProjMgr.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
