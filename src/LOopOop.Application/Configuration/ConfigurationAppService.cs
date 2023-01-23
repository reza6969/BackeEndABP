using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LOopOop.Configuration.Dto;

namespace LOopOop.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LOopOopAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
