using Abp.MultiTenancy;
using SunRose.ProjMgr.Authorization.Users;

namespace SunRose.ProjMgr.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
