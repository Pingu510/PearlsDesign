using System.Collections.Generic;
using System.Windows.Media;

namespace PearlsDesign.Models
{
    internal class PearlGrid
    {
        private Brush defaultColor = Brushes.Red;

        public List<Pearl> Pearls { get; set; }
        public int PearlItemsAccrossGrid { get; private set; }
        public double GridSize { get; private set; }
        public double PearlBeadSize { get; private set; }
        public Brush DefaultColor { get => defaultColor; set => defaultColor = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pearlOnewayItemCount"></param>
        /// <param name="pearlBeadSize"></param>
        public PearlGrid(int pearlOnewayItemCount, int pearlBeadSize)
        {
            PearlItemsAccrossGrid = pearlOnewayItemCount;
            PearlBeadSize = pearlBeadSize;
            GridSize = PearlBeadSize * PearlItemsAccrossGrid;
            GeneratePearlList();
        }

        /// <summary>
        /// Overwrite Pearls with new Pearl Objects
        /// </summary>
        public void GeneratePearlList()
        {
            var pearls = new List<Pearl>();
            var items = System.Math.Pow(PearlItemsAccrossGrid, 2);
            for (int i = 0; i < items; i++)
            {
                pearls.Add(new Pearl(i, defaultColor));
            }
            Pearls = pearls;
        }
    }
}
