using Abp.AutoMapper;
using Lays.Manage.MultiTenancy;
using Lays.Manage.MultiTenancy.Dto;
using Lays.Manage.Web.Areas.Mpa.Models.Common;

namespace Lays.Manage.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}