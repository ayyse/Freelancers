using Xunit;

namespace Freelancers.EntityFrameworkCore;

[CollectionDefinition(FreelancersTestConsts.CollectionDefinitionName)]
public class FreelancersEntityFrameworkCoreCollection : ICollectionFixture<FreelancersEntityFrameworkCoreFixture>
{

}
