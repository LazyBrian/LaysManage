using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Lays.Manage.Authorization.Permissions.Dto;

namespace Lays.Manage.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
