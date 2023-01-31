using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace St.BlogManagement.Admin;

[Dependency(ReplaceServices = true)]
public class BlogManagementAdminBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BlogManagementAdmin";
}
