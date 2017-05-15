using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Lays.Manage.Configuration.Tenants.Dto;

namespace Lays.Manage.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}