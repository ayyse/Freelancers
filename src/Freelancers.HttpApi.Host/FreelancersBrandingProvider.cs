using Microsoft.Extensions.Localization;
using Freelancers.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Freelancers;

[Dependency(ReplaceServices = true)]
public class FreelancersBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<FreelancersResource> _localizer;

    public FreelancersBrandingProvider(IStringLocalizer<FreelancersResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
