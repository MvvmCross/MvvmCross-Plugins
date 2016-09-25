using Plugin.Permissions.Abstractions;

namespace MvvmCross.Plugins.Permissions
{
    public static class MvxPermissionExtensions
    {
        public static Permission ToPermission(this MvxPermission permission)
        {
            switch (permission)
            {
                case MvxPermission.Calendar:
                    return Permission.Calendar;
                case MvxPermission.Camera:
                    return Permission.Camera;
                case MvxPermission.Contacts:
                    return Permission.Contacts;
                case MvxPermission.Location:
                    return Permission.Location;
                case MvxPermission.Microphone:
                    return Permission.Microphone;
                case MvxPermission.Phone:
                    return Permission.Phone;
                case MvxPermission.Photos:
                    return Permission.Photos;
                case MvxPermission.Reminders:
                    return Permission.Reminders;
                case MvxPermission.Sensors:
                    return Permission.Sensors;
                case MvxPermission.Sms:
                    return Permission.Sms;
                case MvxPermission.Storage:
                    return Permission.Storage;
                default:
                    return Permission.Unknown;
            }
        }

        public static PermissionStatus ToPermissionStatus(this MvxPermissionStatus permissionStatus)
        {
            switch (permissionStatus)
            {
                case MvxPermissionStatus.Denied:
                    return PermissionStatus.Denied;
                case MvxPermissionStatus.Disabled:
                    return PermissionStatus.Disabled;
                case MvxPermissionStatus.Granted:
                    return PermissionStatus.Granted;
                case MvxPermissionStatus.Restricted:
                    return PermissionStatus.Restricted;
                default:
                    return PermissionStatus.Unknown;
            }
        }

        public static MvxPermission ToMvxPermission(this Permission permission)
        {
            switch (permission)
            {
                case Permission.Calendar:
                    return MvxPermission.Calendar;
                case Permission.Camera:
                    return MvxPermission.Camera;
                case Permission.Contacts:
                    return MvxPermission.Contacts;
                case Permission.Location:
                    return MvxPermission.Location;
                case Permission.Microphone:
                    return MvxPermission.Microphone;
                case Permission.Phone:
                    return MvxPermission.Phone;
                case Permission.Photos:
                    return MvxPermission.Photos;
                case Permission.Reminders:
                    return MvxPermission.Reminders;
                case Permission.Sensors:
                    return MvxPermission.Sensors;
                case Permission.Sms:
                    return MvxPermission.Sms;
                case Permission.Storage:
                    return MvxPermission.Storage;
                default:
                    return MvxPermission.Unknown;
            }
        }

        public static MvxPermissionStatus ToMvxPermissionStatus(this PermissionStatus permissionStatus)
        {
            switch (permissionStatus)
            {
                case PermissionStatus.Denied:
                    return MvxPermissionStatus.Denied;
                case PermissionStatus.Disabled:
                    return MvxPermissionStatus.Disabled;
                case PermissionStatus.Granted:
                    return MvxPermissionStatus.Granted;
                case PermissionStatus.Restricted:
                    return MvxPermissionStatus.Restricted;
                default:
                    return MvxPermissionStatus.Unknown;
            }
        }
    }
}