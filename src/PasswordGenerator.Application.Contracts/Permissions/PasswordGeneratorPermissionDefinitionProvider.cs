using PasswordGenerator.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PasswordGenerator.Permissions;

public class PasswordGeneratorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PasswordGeneratorPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PasswordGeneratorPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PasswordGeneratorResource>(name);
    }
}
