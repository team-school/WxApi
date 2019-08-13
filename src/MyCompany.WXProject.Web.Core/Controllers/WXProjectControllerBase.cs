using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyCompany.WXProject.Controllers
{
    public abstract class WXProjectControllerBase: AbpController
    {
        protected WXProjectControllerBase()
        {
            LocalizationSourceName = WXProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
