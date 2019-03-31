using Abp.Authorization;
using WENTE.Authorization.Roles;
using WENTE.Authorization.Users;

namespace WENTE.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
