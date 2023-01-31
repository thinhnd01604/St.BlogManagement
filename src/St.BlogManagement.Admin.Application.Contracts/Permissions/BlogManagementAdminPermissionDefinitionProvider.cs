using St.BlogManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace St.BlogManagement.Admin.Permissions;

public class BlogManagementAdminPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BlogManagementAdminPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SamplePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BlogManagementResource>(name);
    }
}
