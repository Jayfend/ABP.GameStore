using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.GameStore.Data;

/* This is used if database provider does't define
 * IGameStoreDbSchemaMigrator implementation.
 */
public class NullGameStoreDbSchemaMigrator : IGameStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
