using Freelancers.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Freelancers.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FreelancersController : AbpControllerBase
{
    protected FreelancersController()
    {
        LocalizationResource = typeof(FreelancersResource);
    }
}
