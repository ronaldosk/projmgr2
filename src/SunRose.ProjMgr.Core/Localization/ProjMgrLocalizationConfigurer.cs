using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SunRose.ProjMgr.Localization
{
    public static class ProjMgrLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProjMgrConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProjMgrLocalizationConfigurer).GetAssembly(),
                        "SunRose.ProjMgr.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
