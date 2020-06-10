using Abp.Application.Services;
using arggio.MultiTenancy.Dto;

namespace arggio.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

