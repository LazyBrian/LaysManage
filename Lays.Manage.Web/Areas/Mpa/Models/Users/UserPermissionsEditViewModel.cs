using Abp.AutoMapper;
using Lays.Manage.Authorization.Users;
using Lays.Manage.Authorization.Users.Dto;
using Lays.Manage.Web.Areas.Mpa.Models.Common;

namespace Lays.Manage.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}