using Abp.Application.Services;
using LOopOop.MultiTenancy.Dto;

namespace LOopOop.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

