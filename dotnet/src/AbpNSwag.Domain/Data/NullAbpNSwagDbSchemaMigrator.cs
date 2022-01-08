using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpNSwag.Data
{
    /* This is used if database provider does't define
     * IAbpNSwagDbSchemaMigrator implementation.
     */
    public class NullAbpNSwagDbSchemaMigrator : IAbpNSwagDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}