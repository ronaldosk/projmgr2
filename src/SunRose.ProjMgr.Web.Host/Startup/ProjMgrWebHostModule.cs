using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SunRose.ProjMgr.Configuration;

namespace SunRose.ProjMgr.Web.Host.Startup
{
    [DependsOn(
       typeof(ProjMgrWebCoreModule))]
    public class ProjMgrWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProjMgrWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjMgrWebHostModule).GetAssembly());
        }
    }
}
