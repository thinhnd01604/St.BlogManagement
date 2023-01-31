using System.Threading.Tasks;

namespace St.BlogManagement.Data;

public interface IBlogManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
