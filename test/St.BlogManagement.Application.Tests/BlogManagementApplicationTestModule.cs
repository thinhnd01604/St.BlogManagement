using Volo.Abp.Modularity;

namespace St.BlogManagement;

[DependsOn(
    typeof(BlogManagementApplicationModule),
    typeof(BlogManagementDomainTestModule)
    )]
public class BlogManagementApplicationTestModule : AbpModule
{

}
