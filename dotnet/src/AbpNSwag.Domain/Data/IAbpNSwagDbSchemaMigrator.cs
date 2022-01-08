using System.Threading.Tasks;

namespace AbpNSwag.Data
{
    public interface IAbpNSwagDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
