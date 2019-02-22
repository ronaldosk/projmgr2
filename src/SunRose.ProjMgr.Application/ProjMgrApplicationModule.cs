using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SunRose.ProjMgr.Authorization;

namespace SunRose.ProjMgr
{
    [DependsOn(
        typeof(ProjMgrCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProjMgrApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProjMgrAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProjMgrApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
