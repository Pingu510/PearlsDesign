using System.Collections.Generic;
using System.Windows.Media;

namespace PearlsDesign.Models
{
    internal class PearlGrid
    {
        private Color defaultColor = Colors.White;
        public int PearlGridSize { get; set; }
        public double PearlBeadSize { get; set; }
        public Color DefaultColor { get => defaultColor; set => defaultColor = value; }

        public List<Pearl> Pearls = new List<Pearl>();
    }
}
