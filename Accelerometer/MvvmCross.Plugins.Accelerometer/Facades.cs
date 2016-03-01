using System;
using MvvmCross.Platform.Core;
using MvvmCross.Plugins.Accelerometer.Abstractions;

namespace MvvmCross.Plugins.Accelerometer
{
    public class MvxAccelerometer
        : IMvxAccelerometer
    {
        private const string WrongVersion = "Should never happen. Did you load platform specific assembly?";
        
        public void Start()
        {
            throw new NotImplementedException(WrongVersion);
        }

        public void Stop()
        {
            throw new NotImplementedException(WrongVersion);
        }

        public bool Started { get; }
        public MvxAccelerometerReading LastReading { get; }
        public event EventHandler<MvxValueEventArgs<MvxAccelerometerReading>> ReadingAvailable;
    }
}
