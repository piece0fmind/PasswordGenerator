using Volo.Abp.Settings;

namespace PasswordGenerator.Settings;

public class PasswordGeneratorSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PasswordGeneratorSettings.MySetting1));
    }
}
