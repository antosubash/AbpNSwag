using AbpNSwag.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpNSwag
{
    [DependsOn(
        typeof(AbpNSwagEntityFrameworkCoreTestModule)
        )]
    public class AbpNSwagDomainTestModule : AbpModule
    {

    }
}