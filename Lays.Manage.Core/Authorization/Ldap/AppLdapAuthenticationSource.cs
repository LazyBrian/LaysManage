using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Lays.Manage.Authorization.Users;
using Lays.Manage.MultiTenancy;

namespace Lays.Manage.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
