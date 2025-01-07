using Volo.Abp.Modularity;

namespace Freelancers;

/* Inherit from this class for your domain layer tests. */
public abstract class FreelancersDomainTestBase<TStartupModule> : FreelancersTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
