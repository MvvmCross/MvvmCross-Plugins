using AccelerometerSample.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace AccelerometerSample.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            // Registers any classes ending with "Service" into the internal
            // Mvx IoC container for use when constructing objects through
            // the container
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
