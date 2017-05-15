using System.Threading.Tasks;
using Abp.Application.Services;
using Lays.Manage.Configuration.Host.Dto;

namespace Lays.Manage.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
