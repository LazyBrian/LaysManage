using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Lays.Manage.Editions.Dto;

namespace Lays.Manage.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}