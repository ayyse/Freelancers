using Freelancers.Samples;
using Xunit;

namespace Freelancers.EntityFrameworkCore.Domains;

[Collection(FreelancersTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<FreelancersEntityFrameworkCoreTestModule>
{

}
