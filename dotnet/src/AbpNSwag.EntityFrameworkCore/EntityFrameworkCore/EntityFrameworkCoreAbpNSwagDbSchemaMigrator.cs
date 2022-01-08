using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpNSwag.Data;
using Volo.Abp.DependencyInjection;

namespace AbpNSwag.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpNSwagDbSchemaMigrator
        : IAbpNSwagDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpNSwagDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpNSwagDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpNSwagDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
