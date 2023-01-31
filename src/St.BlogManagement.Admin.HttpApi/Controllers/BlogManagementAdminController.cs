using St.BlogManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace St.BlogManagement.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BlogManagementAdminController : AbpControllerBase
{
    protected BlogManagementAdminController()
    {
        LocalizationResource = typeof(BlogManagementResource);
    }
}
