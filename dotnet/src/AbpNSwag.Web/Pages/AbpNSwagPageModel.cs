using AbpNSwag.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpNSwag.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpNSwagPageModel : AbpPageModel
    {
        protected AbpNSwagPageModel()
        {
            LocalizationResourceType = typeof(AbpNSwagResource);
        }
    }
}