using St.BlogManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace St.BlogManagement;

[DependsOn(
    typeof(BlogManagementEntityFrameworkCoreTestModule)
    )]
public class BlogManagementDomainTestModule : AbpModule
{

}
