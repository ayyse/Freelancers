using Volo.Abp.Modularity;

namespace Freelancers;

[DependsOn(
    typeof(FreelancersApplicationModule),
    typeof(FreelancersDomainTestModule)
)]
public class FreelancersApplicationTestModule : AbpModule
{

}
