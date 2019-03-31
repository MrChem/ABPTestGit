using System.Threading.Tasks;
using Abp.Application.Services;
using WENTE.Configuration.Dto;

namespace WENTE.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}