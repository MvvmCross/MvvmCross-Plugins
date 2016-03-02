using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Core;
using MvvmCross.Plugins.Accelerometer.Abstractions;

namespace AccelerometerSample.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        private readonly IMvxAccelerometer _accelerometer;
        private MvxCommand _startReadingCommand;
        private MvxCommand _stopReadingCommand;
        private double _x;
        private double _y;
        private double _z;

        public FirstViewModel(IMvxAccelerometer accelerometer)
        {
            _accelerometer = accelerometer;
            _accelerometer.ReadingAvailable += AccelerometerOnReadingAvailable;
        }

        public double X
        {
            get { return _x; }
            set { this.RaiseAndSetIfChanged(ref _x, value); }
        }

        public double Y
        {
            get { return _y; }
            set { this.RaiseAndSetIfChanged(ref _y, value); }
        }

        public double Z
        {
            get { return _z; }
            set { this.RaiseAndSetIfChanged(ref _z, value); }
        }

        public bool Started => _accelerometer.Started;

        public ICommand StartReadingCommand
        {
            get
            {
                return
                    _startReadingCommand = _startReadingCommand ?? new MvxCommand(DoStartReadingCommand, () => !Started);
            }
        }

        public ICommand StopReadingCommand
        {
            get
            {
                return _stopReadingCommand = _stopReadingCommand ?? new MvxCommand(DoStopReadingCommand, () => Started);
            }
        }

        private void AccelerometerOnReadingAvailable(object sender, MvxValueEventArgs<MvxAccelerometerReading> args)
        {
            X = args.Value.X;
            Y = args.Value.Y;
            Z = args.Value.Z;
        }

        private void DoStartReadingCommand()
        {
            _accelerometer.Start();
            RaisePropertyChanged(() => Started);
            _stopReadingCommand.RaiseCanExecuteChanged();
            _startReadingCommand.RaiseCanExecuteChanged();
        }

        private void DoStopReadingCommand()
        {
            _accelerometer.Stop();
            RaisePropertyChanged(() => Started);
            _stopReadingCommand.RaiseCanExecuteChanged();
            _startReadingCommand.RaiseCanExecuteChanged();
        }
    }
}