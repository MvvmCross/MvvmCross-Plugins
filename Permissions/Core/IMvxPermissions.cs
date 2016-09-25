using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvvmCross.Plugins.Permissions
{
    public interface IMvxPermissions
    {
        Task<bool> ShouldShowRequestPermissionRationaleAsync(MvxPermission permission);
        Task<MvxPermissionStatus> CheckPermissionStatusAsync(MvxPermission permission);
        Task<Dictionary<MvxPermission, MvxPermissionStatus>> RequestPermissionsAsync(params MvxPermission[] permissions);
    }
}
