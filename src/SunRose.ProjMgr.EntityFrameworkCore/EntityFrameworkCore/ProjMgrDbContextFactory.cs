using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SunRose.ProjMgr.Configuration;
using SunRose.ProjMgr.Web;

namespace SunRose.ProjMgr.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProjMgrDbContextFactory : IDesignTimeDbContextFactory<ProjMgrDbContext>
    {
        public ProjMgrDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProjMgrDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProjMgrDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProjMgrConsts.ConnectionStringName));

            return new ProjMgrDbContext(builder.Options);
        }
    }
}
