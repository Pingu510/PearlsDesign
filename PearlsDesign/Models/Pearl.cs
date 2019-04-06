using System.Windows.Media;

namespace PearlsDesign.Models
{
    class Pearl
    {
        public Pearl(int id, Brush color)
        {
            Id = id;
            Color = color;
            Test = "Test";
        }

        public int Id { get; set; }
        public Brush Color { get; set; }
        public string Test { get; set; }
    }
}
