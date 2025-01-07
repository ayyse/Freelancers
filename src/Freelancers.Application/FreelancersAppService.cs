using Freelancers.Localization;
using Volo.Abp.Application.Services;

namespace Freelancers;

/* Inherit your application services from this class.
 */
public abstract class FreelancersAppService : ApplicationService
{
    protected FreelancersAppService()
    {
        LocalizationResource = typeof(FreelancersResource);
    }
}
