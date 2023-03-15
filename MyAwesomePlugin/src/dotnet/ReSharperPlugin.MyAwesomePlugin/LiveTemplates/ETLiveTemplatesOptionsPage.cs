// using JetBrains.Application.BuildScript.Application.Zones;
// using JetBrains.Application.UI.Options;
// using JetBrains.Application.UI.Options.OptionsDialog;
// using JetBrains.IDE.UI;
// using JetBrains.Lifetimes;
// using JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope;
// using JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings;
// using JetBrains.ReSharper.LiveTemplates.UI;
// using JetBrains.Rider.Model;
// using ReSharperPlugin.ETPlugin.Icons;
//
// namespace ReSharperPlugin.ETPlugin.LiveTemplates
// {
//     [ZoneMarker(typeof(IRiderModelZone))]
//     [OptionsPage("RiderETLiveTemplatesSettings", "ET", typeof(LogoIcons.ET))]
//     public class ETLiveTemplatesOptionsPage : RiderLiveTemplatesOptionPageBase
//     {
//         public ETLiveTemplatesOptionsPage(Lifetime lifetime,
//             ScopeCategoryUIProvider uiProvider,
//             OptionsPageContext optionsPageContext,
//             OptionsSettingsSmartContext optionsSettingsSmartContext,
//             StoredTemplatesProvider storedTemplatesProvider,
//             ScopeCategoryManager scopeCategoryManager,
//             IDialogHost dialogHost,
//             TemplatesUIFactory uiFactory, IconHostBase iconHostBase)
//             : base(lifetime, uiProvider, optionsPageContext, optionsSettingsSmartContext, storedTemplatesProvider, scopeCategoryManager,
//                 uiFactory, iconHostBase, dialogHost, "CSHARP")
//         {
//         }
//     }
// }