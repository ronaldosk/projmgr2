using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using SunRose.ProjMgr.Authorization.Roles;
using SunRose.ProjMgr.Authorization.Users;
using SunRose.ProjMgr.Configuration;
using SunRose.ProjMgr.Localization;
using SunRose.ProjMgr.MultiTenancy;
using SunRose.ProjMgr.Timing;

namespace SunRose.ProjMgr
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ProjMgrCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            ProjMgrLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = ProjMgrConsts.MultiTenancyEnabled;
             
            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjMgrCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
