using System;
using System.Collections.Generic;
using System.Text;
using Acme.GameStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.GameStore;

/* Inherit your application services from this class.
 */
public abstract class GameStoreAppService : ApplicationService
{
    protected GameStoreAppService()
    {
        LocalizationResource = typeof(GameStoreResource);
    }
}
