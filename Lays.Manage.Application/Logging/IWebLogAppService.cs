using Abp.Application.Services;
using Lays.Manage.Dto;
using Lays.Manage.Logging.Dto;

namespace Lays.Manage.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
