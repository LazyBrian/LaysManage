using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Lays.Manage.Editions.Dto;

namespace Lays.Manage.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}