using Lays.Manage.Dto;

namespace Lays.Manage.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}