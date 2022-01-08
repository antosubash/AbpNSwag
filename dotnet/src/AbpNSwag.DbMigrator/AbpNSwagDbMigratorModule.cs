using AbpNSwag.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpNSwag.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpNSwagEntityFrameworkCoreModule),
        typeof(AbpNSwagApplicationContractsModule)
        )]
    public class AbpNSwagDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
