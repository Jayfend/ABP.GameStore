using System.Threading.Tasks;

namespace Acme.GameStore.Data;

public interface IGameStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
