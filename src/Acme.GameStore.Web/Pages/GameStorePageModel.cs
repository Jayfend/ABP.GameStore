using Acme.GameStore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.GameStore.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class GameStorePageModel : AbpPageModel
{
    protected GameStorePageModel()
    {
        LocalizationResourceType = typeof(GameStoreResource);
    }
}
