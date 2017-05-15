using Abp.Notifications;
using Lays.Manage.Dto;

namespace Lays.Manage.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}