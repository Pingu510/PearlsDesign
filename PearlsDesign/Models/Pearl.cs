using System.Windows.Media;

namespace PearlsDesign.Models
{
    class Pearl
    {
        public Pearl(int id, Brush color)
        {
            Id = id;
            Color = color;
        }

        public int Id { get; set; }
        public Brush Color { get; set; }
    }
}
