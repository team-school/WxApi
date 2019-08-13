using System.Threading.Tasks;
using MyCompany.WXProject.Configuration.Dto;

namespace MyCompany.WXProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
