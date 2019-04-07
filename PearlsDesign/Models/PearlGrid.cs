using System.Collections.Generic;
using System.Windows.Media;

namespace PearlsDesign.Models
{
    internal class PearlGrid
    {
        public List<Pearl> Pearls { get; set; }
        public int PearlItemsAccrossGrid { get; private set; }
        public double GridSize { get; private set; }
        public double PearlBeadSize { get; private set; }
        public SolidColorBrush DefaultColor { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public PearlGrid()
        {
            PearlItemsAccrossGrid = Properties.Settings.Default.GridSize;
            PearlBeadSize = Properties.Settings.Default.PearlSize;
            Color color = Color.FromArgb(
                Properties.Settings.Default.PearlBackgroundColor.A,
                Properties.Settings.Default.PearlBackgroundColor.R,
                Properties.Settings.Default.PearlBackgroundColor.G,
                Properties.Settings.Default.PearlBackgroundColor.B
            );
            DefaultColor = new SolidColorBrush(color);
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
                pearls.Add(new Pearl(i, DefaultColor));
            }
            Pearls = pearls;
        }
    }
}
