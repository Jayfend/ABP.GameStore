using Volo.Abp.Settings;

namespace Acme.GameStore.Settings;

public class GameStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GameStoreSettings.MySetting1));
    }
}
