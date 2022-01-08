using AbpNSwag.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpNSwag.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpNSwagController : AbpControllerBase
    {
        protected AbpNSwagController()
        {
            LocalizationResource = typeof(AbpNSwagResource);
        }
    }
}