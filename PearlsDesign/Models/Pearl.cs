using System.Windows.Media;

namespace PearlsDesign.Models
{
    class Pearl
    {
        public Pearl(int id, SolidColorBrush color)
        {
            Id = id;
            Color = color;
        }

        public int Id { get; set; }
        public SolidColorBrush Color { get; set; }
    }
}
