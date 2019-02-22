using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SunRose.ProjMgr.EntityFrameworkCore
{
    public static class ProjMgrDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProjMgrDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProjMgrDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
