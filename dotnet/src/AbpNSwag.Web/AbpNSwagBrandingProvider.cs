using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpNSwag.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpNSwagBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpNSwag";
    }
}
