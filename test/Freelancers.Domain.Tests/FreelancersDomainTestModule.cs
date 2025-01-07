using Volo.Abp.Modularity;

namespace Freelancers;

[DependsOn(
    typeof(FreelancersDomainModule),
    typeof(FreelancersTestBaseModule)
)]
public class FreelancersDomainTestModule : AbpModule
{

}
