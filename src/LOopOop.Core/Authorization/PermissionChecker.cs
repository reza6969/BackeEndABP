using Abp.Authorization;
using LOopOop.Authorization.Roles;
using LOopOop.Authorization.Users;

namespace LOopOop.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
