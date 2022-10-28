using Volo.Abp.Modularity;

namespace Acme.GameStore;

[DependsOn(
    typeof(GameStoreApplicationModule),
    typeof(GameStoreDomainTestModule)
    )]
public class GameStoreApplicationTestModule : AbpModule
{

}
