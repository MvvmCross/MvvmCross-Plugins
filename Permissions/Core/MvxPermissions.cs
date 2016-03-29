using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;

namespace MvvmCross.Plugins.Permissions
{
    public class MvxPermissions : IMvxPermissions
    {
        public Task<bool> ShouldShowRequestPermissionRationaleAsync(Permission permission)
        {
            return CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(permission);
        }

        public Task<PermissionStatus> CheckPermissionStatusAsync(Permission permission)
        {
            return CrossPermissions.Current.CheckPermissionStatusAsync(permission);
        }

        public Task<Dictionary<Permission, PermissionStatus>> RequestPermissionsAsync(params Permission[] permissions)
        {
            return CrossPermissions.Current.RequestPermissionsAsync(permissions);
        }
    }
}