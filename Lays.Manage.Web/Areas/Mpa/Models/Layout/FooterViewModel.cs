using Lays.Manage.Sessions.Dto;

namespace Lays.Manage.Web.Areas.Mpa.Models.Layout
{
    public class FooterViewModel
    {
        public GetCurrentLoginInformationsOutput LoginInformations { get; set; }

        public string GetProductNameWithEdition()
        {
            var productName = "AbpZeroTemplate";

            if (LoginInformations.Tenant != null && LoginInformations.Tenant.EditionDisplayName != null)
            {
                productName += " " + LoginInformations.Tenant.EditionDisplayName;
            }

            return productName;
        }
    }
}