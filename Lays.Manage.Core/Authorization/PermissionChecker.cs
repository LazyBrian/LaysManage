using Abp.Authorization;
using Lays.Manage.Authorization.Roles;
using Lays.Manage.Authorization.Users;
using Lays.Manage.MultiTenancy;

namespace Lays.Manage.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
