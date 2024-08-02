using System.Threading.Tasks;

namespace ABPCource.Demo1.Data;

public interface IDemo1DbSchemaMigrator
{
    Task MigrateAsync();
}
