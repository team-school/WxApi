using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompany.WXProject.MultiTenancy.Dto;

namespace MyCompany.WXProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

