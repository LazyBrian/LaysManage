using System.ComponentModel.DataAnnotations;

namespace Lays.Manage.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        public string TenancyName { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}