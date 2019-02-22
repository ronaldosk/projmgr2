using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SunRose.ProjMgr.Configuration;
using SunRose.ProjMgr.EntityFrameworkCore;
using SunRose.ProjMgr.Migrator.DependencyInjection;

namespace SunRose.ProjMgr.Migrator
{
    [DependsOn(typeof(ProjMgrEntityFrameworkModule))]
    public class ProjMgrMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ProjMgrMigratorModule(ProjMgrEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ProjMgrMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ProjMgrConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjMgrMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
