using Caliburn.Micro;
using PearlsDesign.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PearlsDesign.ViewModels
{
    internal class ShellViewModel : Screen
    {
        private string _firstName = "N/A";
        private List<Pearl> _pearls;
        private Pearl _pearl1;
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

        public Pearl Pearl1
        {
            get { return _pearl1; }
            set
            {
                _pearl1 = value;
                NotifyOfPropertyChange(() => Pearl1);
            }
        }

        //public List<Pearl> Pearls
        //{
        //    get { return _pearls; }
        //    set
        //    {
        //        _pearls = value;
        //        NotifyOfPropertyChange(() => Pearls);
        //    }
        //}

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public ShellViewModel()
        {
            PearlGrid = new PearlGrid(3, 20);
            //Pearls = new List<Pearl>()
            //{
            //    new Pearl(0, Brushes.LightPink),
            //    new Pearl(1, Brushes.Pink),
            //    new Pearl(2, Brushes.HotPink),
            //    new Pearl(3, Brushes.DeepPink)
            //};
            //Pearl1 = Pearls[0];            
        }
    }
}
