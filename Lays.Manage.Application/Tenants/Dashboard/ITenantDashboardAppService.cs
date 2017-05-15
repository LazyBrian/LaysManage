using Abp.Application.Services;
using Lays.Manage.Tenants.Dashboard.Dto;

namespace Lays.Manage.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
