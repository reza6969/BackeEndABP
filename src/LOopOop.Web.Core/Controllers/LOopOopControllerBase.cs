using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LOopOop.Controllers
{
    public abstract class LOopOopControllerBase: AbpController
    {
        protected LOopOopControllerBase()
        {
            LocalizationSourceName = LOopOopConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
