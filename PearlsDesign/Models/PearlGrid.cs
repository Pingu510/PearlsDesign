using System.Collections.Generic;
using System.Windows.Media;

namespace PearlsDesign.Models
{
    internal class PearlGrid
    {
        private Color defaultColor = Colors.White;

        public List<Pearl> Pearls;
        public int PearlGridSize { get; private set; }
        public double PearlBeadSize { get; private set; }
        public Color DefaultColor { get => defaultColor; set => defaultColor = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size"></param>
        /// <param name="pearlBeadSize"></param>
        public PearlGrid(int size, double pearlBeadSize)
        {
            PearlGridSize = size;
            PearlBeadSize = pearlBeadSize;
        }

        /// <summary>
        /// Overwrite Pearls with new Pearl Objects
        /// </summary>
        public void GeneratePearlList()
        {
            var pearls = new List<Pearl>();
            var times = PearlGridSize ^ 2;
            for (int i = 0; i < times; i++)
            {
                pearls.Add(new Pearl(i, defaultColor));
            }
            Pearls = pearls;
        }
    }
}
