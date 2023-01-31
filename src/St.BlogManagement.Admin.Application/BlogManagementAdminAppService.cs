using Volo.Abp.Application.Services;

namespace St.BlogManagement.Admin;

/* Inherit your application services from this class.
 */
public abstract class BlogManagementAdminAppService : ApplicationService
{
    protected BlogManagementAdminAppService()
    {
        LocalizationResource = typeof(BlogManagementDomainModule);
    }
}
