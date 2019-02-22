using Microsoft.AspNetCore.Antiforgery;
using SunRose.ProjMgr.Controllers;

namespace SunRose.ProjMgr.Web.Host.Controllers
{
    public class AntiForgeryController : ProjMgrControllerBase
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
