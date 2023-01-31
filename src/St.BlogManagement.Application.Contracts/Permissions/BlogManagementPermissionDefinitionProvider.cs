using St.BlogManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace St.BlogManagement.Permissions;

public class BlogManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BlogManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BlogManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BlogManagementResource>(name);
    }
}
