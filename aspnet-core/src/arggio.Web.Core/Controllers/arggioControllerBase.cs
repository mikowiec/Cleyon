using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace arggio.Controllers
{
    public abstract class arggioControllerBase: AbpController
    {
        protected arggioControllerBase()
        {
            LocalizationSourceName = arggioConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
