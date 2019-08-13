using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.WXProject.Authorization;

namespace MyCompany.WXProject
{
    [DependsOn(
        typeof(WXProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WXProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WXProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WXProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
