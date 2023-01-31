using St.BlogManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace St.BlogManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BlogManagementController : AbpControllerBase
{
    protected BlogManagementController()
    {
        LocalizationResource = typeof(BlogManagementResource);
    }
}
