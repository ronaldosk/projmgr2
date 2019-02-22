using System.Collections.Generic;

namespace SunRose.ProjMgr.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
