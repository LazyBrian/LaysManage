using System.Threading.Tasks;
using Abp.Application.Services;
using Lays.Manage.Configuration.Tenants.Dto;

namespace Lays.Manage.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);
    }
}
