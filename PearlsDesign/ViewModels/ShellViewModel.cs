using Caliburn.Micro;
using PearlsDesign.Models;
using System;
using System.Windows.Media;

namespace PearlsDesign.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {
        private IWindowManager manager = new WindowManager();
        private PearlGrid _pearlGrid;
        private SolidColorBrush _colorOne;
        private SolidColorBrush _colorTwo;

        public PearlGrid PearlGrid
        {
            get { return _pearlGrid; }
            set
            {
                _pearlGrid = value;
                NotifyOfPropertyChange(() => PearlGrid);
            }
        }
        public SolidColorBrush ColorOne
        {
            get { return _colorOne; }
            set {
                _colorOne = value;
                NotifyOfPropertyChange(() => ColorOne);
            }
        }
        public SolidColorBrush ColorTwo
        {
            get { return _colorTwo; }
            set {
                _colorTwo = value;
                NotifyOfPropertyChange(() => ColorTwo);
            }
        }

        /// <summary>
        /// Constructor
        /// Generates basic PearlGrid
        /// </summary>
        public ShellViewModel()
        {
            ColorOne = new SolidColorBrush(Colors.Black);
            ColorTwo = new SolidColorBrush(Colors.White);
            GenerateNewGrid();
        }

        /// <summary>
        /// Generates new PearlGrid based on Settings
        /// </summary>
        public void GenerateNewGrid()
        {
            PearlGrid = new PearlGrid();
        }

        /// <summary>
        /// Opens the Settings Page
        /// </summary>
        public void OpenSettingsPage()
        {
            manager.ShowDialog(new SettingsViewModel(), null, null);
        }

        /// <summary>
        /// LeftMouseDownEvent on Pearl(button)
        /// </summary>
        /// <param name="button"></param>
        public void Pearl_LeftClick(System.Windows.Controls.Button button)
        {
            Int32.TryParse(button.Uid, out int id);
            var pearl = PearlGrid.Pearls.Find(x => x.Id == id);
            pearl.FillColor = ColorOne;
        }

        /// <summary>
        /// RightMouseDownEvent on Pearl(button)
        /// </summary>
        /// <param name="button"></param>
        public void Pearl_RightClick(System.Windows.Controls.Button button)
        {
            Int32.TryParse(button.Uid, out int id);
            var pearl = PearlGrid.Pearls.Find(x => x.Id == id);
            pearl.FillColor = ColorTwo;
        }
    }
}
