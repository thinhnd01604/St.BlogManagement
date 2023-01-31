using St.BlogManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace St.BlogManagement.Admin.Web;

public abstract class BlogManagementAdminComponentBase : AbpComponentBase
{
    protected BlogManagementAdminComponentBase()
    {
        LocalizationResource = typeof(BlogManagementResource);
    }
}