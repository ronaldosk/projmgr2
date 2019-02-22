using System.Threading.Tasks;
using Abp.Application.Services;
using SunRose.ProjMgr.Sessions.Dto;

namespace SunRose.ProjMgr.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
