using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Lays.Manage.Authorization.Permissions.Dto;

namespace Lays.Manage.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}