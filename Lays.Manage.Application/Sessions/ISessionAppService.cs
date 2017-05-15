using System.Threading.Tasks;
using Abp.Application.Services;
using Lays.Manage.Sessions.Dto;

namespace Lays.Manage.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
