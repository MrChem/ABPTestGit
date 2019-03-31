using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using WENTE.Configuration.Dto;

namespace WENTE.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WENTEAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
