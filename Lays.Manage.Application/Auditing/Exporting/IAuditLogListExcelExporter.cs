using System.Collections.Generic;
using Lays.Manage.Auditing.Dto;
using Lays.Manage.Dto;

namespace Lays.Manage.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
