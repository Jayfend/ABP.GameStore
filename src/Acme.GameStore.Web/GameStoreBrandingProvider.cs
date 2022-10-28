using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.GameStore.Web;

[Dependency(ReplaceServices = true)]
public class GameStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GameStore";
}
