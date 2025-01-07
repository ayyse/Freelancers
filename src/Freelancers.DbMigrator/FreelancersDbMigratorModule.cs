using Freelancers.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Freelancers.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FreelancersEntityFrameworkCoreModule),
    typeof(FreelancersApplicationContractsModule)
)]
public class FreelancersDbMigratorModule : AbpModule
{
}
