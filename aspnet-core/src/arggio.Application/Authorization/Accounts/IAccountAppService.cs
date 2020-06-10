using System.Threading.Tasks;
using Abp.Application.Services;
using arggio.Authorization.Accounts.Dto;

namespace arggio.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
