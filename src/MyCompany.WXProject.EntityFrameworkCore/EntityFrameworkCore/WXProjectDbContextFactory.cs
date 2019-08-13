using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyCompany.WXProject.Configuration;
using MyCompany.WXProject.Web;

namespace MyCompany.WXProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WXProjectDbContextFactory : IDesignTimeDbContextFactory<WXProjectDbContext>
    {
        public WXProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WXProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WXProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WXProjectConsts.ConnectionStringName));

            return new WXProjectDbContext(builder.Options);
        }
    }
}
