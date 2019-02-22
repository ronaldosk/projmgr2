using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SunRose.ProjMgr.Configuration.Dto;

namespace SunRose.ProjMgr.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProjMgrAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
