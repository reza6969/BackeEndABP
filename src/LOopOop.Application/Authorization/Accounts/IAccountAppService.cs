using System.Threading.Tasks;
using Abp.Application.Services;
using LOopOop.Authorization.Accounts.Dto;

namespace LOopOop.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
