using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SunRose.ProjMgr.Authorization.Users;

namespace SunRose.ProjMgr.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
