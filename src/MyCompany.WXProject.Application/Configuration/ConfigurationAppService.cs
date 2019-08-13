using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyCompany.WXProject.Configuration.Dto;

namespace MyCompany.WXProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WXProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
