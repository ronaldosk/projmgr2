using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SunRose.ProjMgr.Authorization.Roles;
using SunRose.ProjMgr.Authorization.Users;
using SunRose.ProjMgr.MultiTenancy;

namespace SunRose.ProjMgr.EntityFrameworkCore
{
    public class ProjMgrDbContext : AbpZeroDbContext<Tenant, Role, User, ProjMgrDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProjMgrDbContext(DbContextOptions<ProjMgrDbContext> options)
            : base(options)
        {
        }
    }
}
