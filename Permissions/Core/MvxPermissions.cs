using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plugin.Permissions;

namespace MvvmCross.Plugins.Permissions
{
    public class MvxPermissions : IMvxPermissions
    {
        public Task<bool> ShouldShowRequestPermissionRationaleAsync(MvxPermission permission)
        {
            return CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(permission.ToPermission());
        }

        public async Task<MvxPermissionStatus> CheckPermissionStatusAsync(MvxPermission permission)
        {
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(permission.ToPermission()).ConfigureAwait(false);
            return status.ToMvxPermissionStatus();
        }

        public async Task<Dictionary<MvxPermission, MvxPermissionStatus>> RequestPermissionsAsync(params MvxPermission[] permissions)
        {
            var nativePermissions = permissions.Select(p => p.ToPermission()).ToArray();

            var status = await CrossPermissions.Current.RequestPermissionsAsync(nativePermissions).ConfigureAwait(false);
            return status.ToDictionary(k => k.Key.ToMvxPermission(), v => v.Value.ToMvxPermissionStatus());
        }
    }
}