using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Lays.Manage.Web.Areas.Mpa.Models.Common.Modals;
using Lays.Manage.Web.Controllers;

namespace Lays.Manage.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : AbpZeroTemplateControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}