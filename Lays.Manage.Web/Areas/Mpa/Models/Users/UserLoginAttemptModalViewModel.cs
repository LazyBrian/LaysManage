using System.Collections.Generic;
using Lays.Manage.Authorization.Users.Dto;

namespace Lays.Manage.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}