using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Lays.Manage.Authorization.Users;

namespace Lays.Manage.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}