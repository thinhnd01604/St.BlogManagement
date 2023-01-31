using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace St.BlogManagement.Web;

[Dependency(ReplaceServices = true)]
public class BlogManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BlogManagement";
}
