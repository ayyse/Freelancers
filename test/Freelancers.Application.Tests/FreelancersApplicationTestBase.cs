using Volo.Abp.Modularity;

namespace Freelancers;

public abstract class FreelancersApplicationTestBase<TStartupModule> : FreelancersTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
