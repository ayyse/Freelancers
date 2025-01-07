using System.Threading.Tasks;

namespace Freelancers.Data;

public interface IFreelancersDbSchemaMigrator
{
    Task MigrateAsync();
}
