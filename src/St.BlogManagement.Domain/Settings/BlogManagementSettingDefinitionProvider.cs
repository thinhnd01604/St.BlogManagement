using Volo.Abp.Settings;

namespace St.BlogManagement.Settings;

public class BlogManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BlogManagementSettings.MySetting1));
    }
}
