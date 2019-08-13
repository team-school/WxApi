using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCompany.WXProject.EntityFrameworkCore
{
    public static class WXProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WXProjectDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WXProjectDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
