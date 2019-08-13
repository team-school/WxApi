using Microsoft.AspNetCore.Antiforgery;
using MyCompany.WXProject.Controllers;

namespace MyCompany.WXProject.Web.Host.Controllers
{
    public class AntiForgeryController : WXProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
