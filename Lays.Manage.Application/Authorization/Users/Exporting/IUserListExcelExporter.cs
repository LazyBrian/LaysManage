using System.Collections.Generic;
using Lays.Manage.Authorization.Users.Dto;
using Lays.Manage.Dto;

namespace Lays.Manage.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}