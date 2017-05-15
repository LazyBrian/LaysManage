using System.Threading.Tasks;
using Abp.Configuration;

namespace Lays.Manage.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
