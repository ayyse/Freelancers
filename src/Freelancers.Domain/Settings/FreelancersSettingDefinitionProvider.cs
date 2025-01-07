using Volo.Abp.Settings;

namespace Freelancers.Settings;

public class FreelancersSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FreelancersSettings.MySetting1));
    }
}
