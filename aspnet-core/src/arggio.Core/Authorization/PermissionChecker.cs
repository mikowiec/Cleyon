using Abp.Authorization;
using arggio.Authorization.Roles;
using arggio.Authorization.Users;

namespace arggio.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
