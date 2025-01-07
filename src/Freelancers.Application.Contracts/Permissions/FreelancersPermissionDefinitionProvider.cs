using Freelancers.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Freelancers.Permissions;

public class FreelancersPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FreelancersPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(FreelancersPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FreelancersResource>(name);
    }
}
