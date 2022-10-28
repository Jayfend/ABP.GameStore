using Acme.GameStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.GameStore;

[DependsOn(
    typeof(GameStoreEntityFrameworkCoreTestModule)
    )]
public class GameStoreDomainTestModule : AbpModule
{

}
