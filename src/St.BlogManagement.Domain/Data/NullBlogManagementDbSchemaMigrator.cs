using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace St.BlogManagement.Data;

/* This is used if database provider does't define
 * IBlogManagementDbSchemaMigrator implementation.
 */
public class NullBlogManagementDbSchemaMigrator : IBlogManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
