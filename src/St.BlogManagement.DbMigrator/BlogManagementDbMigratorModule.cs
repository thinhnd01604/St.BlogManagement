using St.BlogManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace St.BlogManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BlogManagementEntityFrameworkCoreModule),
    typeof(BlogManagementApplicationContractsModule)
    )]
public class BlogManagementDbMigratorModule : AbpModule
{

}
