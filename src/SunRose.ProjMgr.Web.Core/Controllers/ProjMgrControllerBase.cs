using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SunRose.ProjMgr.Controllers
{
    public abstract class ProjMgrControllerBase: AbpController
    {
        protected ProjMgrControllerBase()
        {
            LocalizationSourceName = ProjMgrConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
