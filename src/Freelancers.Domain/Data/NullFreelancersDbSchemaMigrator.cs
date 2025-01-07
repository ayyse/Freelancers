using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Freelancers.Data;

/* This is used if database provider does't define
 * IFreelancersDbSchemaMigrator implementation.
 */
public class NullFreelancersDbSchemaMigrator : IFreelancersDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
