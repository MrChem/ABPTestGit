using System.Threading.Tasks;
using Abp.Application.Services;
using WENTE.Sessions.Dto;

namespace WENTE.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
