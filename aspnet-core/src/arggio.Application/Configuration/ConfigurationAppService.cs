using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using arggio.Configuration.Dto;

namespace arggio.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : arggioAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
