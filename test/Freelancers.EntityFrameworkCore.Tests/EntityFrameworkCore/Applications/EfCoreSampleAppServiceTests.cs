using Freelancers.Samples;
using Xunit;

namespace Freelancers.EntityFrameworkCore.Applications;

[Collection(FreelancersTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FreelancersEntityFrameworkCoreTestModule>
{

}
