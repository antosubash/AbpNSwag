using System;
using System.Collections.Generic;
using System.Text;
using AbpNSwag.Localization;
using Volo.Abp.Application.Services;

namespace AbpNSwag
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpNSwagAppService : ApplicationService
    {
        protected AbpNSwagAppService()
        {
            LocalizationResource = typeof(AbpNSwagResource);
        }
    }
}
