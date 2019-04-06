using Caliburn.Micro;
using PearlsDesign.Models;

namespace PearlsDesign.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {
        private IWindowManager manager = new WindowManager();
        private PearlGrid _pearlGrid;

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
    }
}
