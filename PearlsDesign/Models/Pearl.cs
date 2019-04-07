using System.ComponentModel;
using System.Windows.Media;

namespace PearlsDesign.Models
{
    internal class Pearl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private SolidColorBrush _fillColor;
        
        public int Id { get; set; }
        public SolidColorBrush FillColor
        {
            get => _fillColor;
            set
            {
                _fillColor = value;
                OnPropertyChanged("FillColor");
            }
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fillColor"></param>
        public Pearl(int id, SolidColorBrush fillColor)
        {
            Id = id;
            FillColor = fillColor;
        }
                
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
