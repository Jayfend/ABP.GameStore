using Acme.GameStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.GameStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GameStoreEntityFrameworkCoreModule),
    typeof(GameStoreApplicationContractsModule)
    )]
public class GameStoreDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
