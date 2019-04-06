using System.Collections.Generic;
using System.Windows.Media;

namespace PearlsDesign.Models
{
    internal class PearlGrid
    {
        private Brush defaultColor = Brushes.Red;

        public List<Pearl> Pearls { get; set; }
        public int PearlGridSize { get; private set; }
        public double PearlBeadSize { get; private set; }
        public Brush DefaultColor { get => defaultColor; set => defaultColor = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gridSize"></param>
        /// <param name="pearlBeadSize"></param>
        public PearlGrid(int gridSize, double pearlBeadSize)
        {
            PearlGridSize = gridSize;
            PearlBeadSize = pearlBeadSize;
            GeneratePearlList();
        }

        /// <summary>
        /// Overwrite Pearls with new Pearl Objects
        /// </summary>
        public void GeneratePearlList()
        {
            var pearls = new List<Pearl>();
            var times = System.Math.Pow(PearlGridSize, 2);
            for (int i = 0; i < times; i++)
            {
                pearls.Add(new Pearl(i, defaultColor));
            }
            Pearls = pearls;
        }
    }
}
