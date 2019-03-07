using System.Windows.Media;

namespace PearlsDesign.Models
{
    class Pearl
    {
        public Pearl(int id, Color color)
        {
            Id = id;
            Color = color;
        }

        public int Id { get; set; }
        public Color Color { get; set; }
    }
}
