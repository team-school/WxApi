using Abp.Authorization;
using MyCompany.WXProject.Authorization.Roles;
using MyCompany.WXProject.Authorization.Users;

namespace MyCompany.WXProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
