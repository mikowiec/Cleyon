using System.Threading.Tasks;
using Abp.Application.Services;
using arggio.Sessions.Dto;

namespace arggio.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
