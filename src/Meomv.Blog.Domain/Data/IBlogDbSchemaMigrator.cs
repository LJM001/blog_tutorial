using System.Threading.Tasks;

namespace Meomv.Blog.Data
{
    public interface IBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
