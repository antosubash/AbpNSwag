using Volo.Abp.Settings;

namespace AbpNSwag.Settings
{
    public class AbpNSwagSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpNSwagSettings.MySetting1));
        }
    }
}
