using Caliburn.Micro;
using System.Windows;
using System.Windows.Media;

namespace PearlsDesign.ViewModels
{
    internal class SettingsViewModel : Screen
    {
        private int _gridHeightSize;
        private int _gridWidthSize;
        private double _pearlSize;
        private double _applicationWidth;
        private double _applicationHeight;
        private SolidColorBrush _gridBackgroundColor;
        private SolidColorBrush _inputPearlColor;


        public int GridHeightSize
        {
            get { return _gridHeightSize; }
            set
            {
                _gridHeightSize = value;
                NotifyOfPropertyChange(() => GridHeightSize);
            }
        }

        public int GridWidthSize
        {
            get { return _gridWidthSize; }
            set
            {
                _gridWidthSize = value;
                NotifyOfPropertyChange(() => GridWidthSize);
            }
        }

        public double PearlSize
        {
            get { return _pearlSize; }
            set
            {
                _pearlSize = value;
                NotifyOfPropertyChange(() => PearlSize);
            }
        }

        public double ApplicationWidth
        {
            get { return _applicationWidth; }
            set
            {
                _applicationWidth = value;
                NotifyOfPropertyChange(() => ApplicationWidth);
            }
        }

        public double ApplicationHeight
        {
            get { return _applicationHeight; }
            set
            {
                _applicationHeight = value;
                NotifyOfPropertyChange(() => ApplicationHeight);
            }
        }

        public SolidColorBrush GridBackgroundColor
        {
            get { return _gridBackgroundColor; }
            set
            {
                _gridBackgroundColor = value;
                NotifyOfPropertyChange(() => GridBackgroundColor);
            }
        }

        /// <summary>
        /// Constructor
        /// Get settings from Properties.Settings
        /// </summary>
        public SettingsViewModel()
        {
            Color color = Color.FromArgb(
                Properties.Settings.Default.PearlBackgroundColor.A,
                Properties.Settings.Default.PearlBackgroundColor.R,
                Properties.Settings.Default.PearlBackgroundColor.G,
                Properties.Settings.Default.PearlBackgroundColor.B
            );
            GridBackgroundColor = new SolidColorBrush(color);
            GridHeightSize = Properties.Settings.Default.GridHeightSize;
            GridWidthSize = Properties.Settings.Default.GridWidthSize;
            PearlSize = Properties.Settings.Default.PearlSize;
            ApplicationHeight = Properties.Settings.Default.ApplicationHeight;
            ApplicationWidth = Properties.Settings.Default.ApplicationWidth;
        }

        /// <summary>
        /// Save Settings and update Properties.Settings
        /// </summary>
        public void SaveSettings()
        {
            if (_inputPearlColor != null)
            {
                var tmpC = System.Drawing.Color.FromArgb(
                    _inputPearlColor.Color.A,
                    _inputPearlColor.Color.R,
                    _inputPearlColor.Color.G,
                    _inputPearlColor.Color.B
                );
                Properties.Settings.Default.PearlBackgroundColor = tmpC;
            }
            Properties.Settings.Default.GridHeightSize = GridHeightSize;
            Properties.Settings.Default.GridWidthSize = GridWidthSize;
            Properties.Settings.Default.PearlSize = PearlSize;
            Properties.Settings.Default.ApplicationHeight = ApplicationHeight;
            Properties.Settings.Default.ApplicationWidth = ApplicationWidth;

            Properties.Settings.Default.Save();
            TryClose();
        }

        /// <summary>
        /// Saves the set BackgroundPearlColor as a temporary value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NewPearlColor(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            _inputPearlColor = new SolidColorBrush();
            _inputPearlColor.Color = e.NewValue.Value;
        }
    }
}
