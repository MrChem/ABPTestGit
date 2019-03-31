using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WENTE.MultiTenancy.Dto;

namespace WENTE.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
