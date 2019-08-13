using Abp.Application.Services.Dto;

namespace MyCompany.WXProject.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

