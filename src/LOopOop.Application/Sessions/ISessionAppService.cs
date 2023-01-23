using System.Threading.Tasks;
using Abp.Application.Services;
using LOopOop.Sessions.Dto;

namespace LOopOop.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
