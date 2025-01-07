using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Freelancers.Data;
using Volo.Abp.DependencyInjection;

namespace Freelancers.EntityFrameworkCore;

public class EntityFrameworkCoreFreelancersDbSchemaMigrator
    : IFreelancersDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFreelancersDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the FreelancersDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FreelancersDbContext>()
            .Database
            .MigrateAsync();
    }
}
