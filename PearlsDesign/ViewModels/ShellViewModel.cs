using Caliburn.Micro;
using PearlsDesign.Models;

namespace PearlsDesign.ViewModels
{
    internal class ShellViewModel : Screen
    {
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

        public ShellViewModel()
        {
            PearlGrid = new PearlGrid(50, 20);
        }
    }
}
