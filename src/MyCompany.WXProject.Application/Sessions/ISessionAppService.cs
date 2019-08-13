using System.Threading.Tasks;
using Abp.Application.Services;
using MyCompany.WXProject.Sessions.Dto;

namespace MyCompany.WXProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
