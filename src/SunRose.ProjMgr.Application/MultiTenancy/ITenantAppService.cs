using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SunRose.ProjMgr.MultiTenancy.Dto;

namespace SunRose.ProjMgr.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

