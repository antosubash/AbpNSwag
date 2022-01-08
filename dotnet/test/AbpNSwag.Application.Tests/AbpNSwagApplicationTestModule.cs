using Volo.Abp.Modularity;

namespace AbpNSwag
{
    [DependsOn(
        typeof(AbpNSwagApplicationModule),
        typeof(AbpNSwagDomainTestModule)
        )]
    public class AbpNSwagApplicationTestModule : AbpModule
    {

    }
}