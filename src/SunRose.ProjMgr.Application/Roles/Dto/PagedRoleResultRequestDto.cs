using Abp.Application.Services.Dto;

namespace SunRose.ProjMgr.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

