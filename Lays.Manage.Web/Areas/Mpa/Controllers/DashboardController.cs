using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Lays.Manage.Authorization;
using Lays.Manage.Web.Controllers;

namespace Lays.Manage.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}