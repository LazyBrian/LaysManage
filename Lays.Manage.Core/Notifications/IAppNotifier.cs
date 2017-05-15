using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Lays.Manage.Authorization.Users;
using Lays.Manage.MultiTenancy;

namespace Lays.Manage.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
