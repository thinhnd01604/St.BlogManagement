using System;
using System.Collections.Generic;
using System.Text;
using St.BlogManagement.Localization;
using Volo.Abp.Application.Services;

namespace St.BlogManagement;

/* Inherit your application services from this class.
 */
public abstract class BlogManagementAppService : ApplicationService
{
    protected BlogManagementAppService()
    {
        LocalizationResource = typeof(BlogManagementResource);
    }
}
