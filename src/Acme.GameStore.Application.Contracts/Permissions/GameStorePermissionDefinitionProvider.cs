using Acme.GameStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.GameStore.Permissions;

public class GameStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GameStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GameStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GameStoreResource>(name);
    }
}
