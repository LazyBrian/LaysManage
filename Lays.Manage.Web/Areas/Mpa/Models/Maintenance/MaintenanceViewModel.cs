using System.Collections.Generic;
using Lays.Manage.Caching.Dto;

namespace Lays.Manage.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}