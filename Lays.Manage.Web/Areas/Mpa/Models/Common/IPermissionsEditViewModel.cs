using System.Collections.Generic;
using Lays.Manage.Authorization.Permissions.Dto;

namespace Lays.Manage.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}