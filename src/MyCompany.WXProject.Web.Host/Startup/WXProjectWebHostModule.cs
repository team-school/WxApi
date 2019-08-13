using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.WXProject.Configuration;

namespace MyCompany.WXProject.Web.Host.Startup
{
    [DependsOn(
       typeof(WXProjectWebCoreModule))]
    public class WXProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WXProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WXProjectWebHostModule).GetAssembly());
        }
    }
}
