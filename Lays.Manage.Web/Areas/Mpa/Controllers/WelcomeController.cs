using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Lays.Manage.Web.Controllers;

namespace Lays.Manage.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}