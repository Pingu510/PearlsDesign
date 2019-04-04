using PearlsDesign.Contexts.Commands;
using PearlsDesign.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PearlsDesign.Contexts
{
    internal class MainViewContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Rectangle> Rectangles = new ObservableCollection<Rectangle>();

        #region Commands
        public ICommand Btn_New_Clicked_Command { get; set; }
        public ICommand Btn_Save_Clicked_Command { get; set; }
        #endregion

        #region Properties
        public int GridSize { get; set; }
        public double PearlSize { get; set; }
        #endregion

        public MainViewContext()
        {
            Btn_New_Clicked_Command = new DelegateCommand(GenerateNewGrid, CanExecuteMethod);
            Btn_Save_Clicked_Command = new DelegateCommand(SaveGrid, CanExecuteMethod);

            PearlGrid grid = new PearlGrid(3, 15);
        }

        //Sends events when a property has changed
        private void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }

        private bool CanExecuteMethod(object parameter)
        {
            return true;
        }

        #region View Interface
        // Generate a new grid
        private void GenerateNewGrid(object property)
        {
            //GeneratePearlCanvas();
        }

        // Save exsisting grid
        private void SaveGrid(object property)
        {
        }
        #endregion

        /// <summary>
        /// Generates the context for the view pearl grid
        /// </summary>
        /// <param name="pearlGrid"></param>
        public void GeneratePearlCanvas(PearlGrid pearlGrid)
        {
            foreach (var pearl in pearlGrid.Pearls)
            {
                Rectangles.Add(new Rectangle()
                {
                    Fill = Brushes.Aqua,
                    //Stroke = Brushes.Black,
                    Height = pearlGrid.PearlBeadSize,
                    Width = pearlGrid.PearlBeadSize,
                    Margin = new Thickness(1)
                });
            }
        }
    }
}
