using Abp.Authorization;
using SunRose.ProjMgr.Authorization.Roles;
using SunRose.ProjMgr.Authorization.Users;

namespace SunRose.ProjMgr.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
