using St.BlogManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace St.BlogManagement.Web.Pages;

public abstract class BlogManagementPageModel : AbpPageModel
{
    protected BlogManagementPageModel()
    {
        LocalizationResourceType = typeof(BlogManagementResource);
    }
}
