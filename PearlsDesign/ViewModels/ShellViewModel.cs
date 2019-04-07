using Caliburn.Micro;
using PearlsDesign.Models;
using System.Windows;
using System.Linq;
using System;
using System.Windows.Media;

namespace PearlsDesign.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {
        private IWindowManager manager = new WindowManager();
        private PearlGrid _pearlGrid;
        private SolidColorBrush _colorOne;

        public SolidColorBrush ColorOne
        {
            get { return _colorOne; }
            set {
                _colorOne = value;
                NotifyOfPropertyChange(() => ColorOne);
            }
        }

        public PearlGrid PearlGrid
        {
            get { return _pearlGrid; }
            set
            {
                _pearlGrid = value;
                NotifyOfPropertyChange(() => PearlGrid);
            }
        }

        /// <summary>
        /// Constructor
        /// Generates basic PearlGrid
        /// </summary>
        public ShellViewModel()
        {
            ColorOne = new SolidColorBrush(Colors.Aqua);
            GenerateNewGrid();
        }

        public void GenerateNewGrid()
        {
            PearlGrid = new PearlGrid();
        }

        public void OpenSettingsPage()
        {
            manager.ShowDialog(new SettingsViewModel(), null, null);
        }

        public void Pearl_Click(System.Windows.Controls.Button button)
        {
            Int32.TryParse(button.Uid, out int id);
            var pearl = PearlGrid.Pearls.Find(x => x.Id == id);
            pearl.Color = ColorOne;
            //ColorOne = new SolidColorBrush(Colors.Black);
            //NotifyOfPropertyChange(() => PearlGrid.Pearls[id].Color);
        }
    }
}
