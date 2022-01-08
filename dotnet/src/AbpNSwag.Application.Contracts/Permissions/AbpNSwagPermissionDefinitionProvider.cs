using AbpNSwag.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpNSwag.Permissions
{
    public class AbpNSwagPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpNSwagPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpNSwagPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpNSwagResource>(name);
        }
    }
}
