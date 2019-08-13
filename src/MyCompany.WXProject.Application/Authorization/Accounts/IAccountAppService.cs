using System.Threading.Tasks;
using Abp.Application.Services;
using MyCompany.WXProject.Authorization.Accounts.Dto;

namespace MyCompany.WXProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
