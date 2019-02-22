using System.Threading.Tasks;
using SunRose.ProjMgr.Configuration.Dto;

namespace SunRose.ProjMgr.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
