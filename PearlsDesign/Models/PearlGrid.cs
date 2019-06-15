using System.Collections.Generic;
using System.Windows.Media;

namespace PearlsDesign.Models
{
    internal class PearlGrid
    {
        public List<Pearl> Pearls { get; set; }
        public SolidColorBrush DefaultColor { get; private set; }

        /// <summary>
        /// Items/pearls Vertically
        /// </summary>
        public int ItemsAccrossGridHeight { get; private set; }

        /// <summary>
        /// Items/pearls Horizontaly
        /// </summary>
        public int ItemsAccrossGridWidth { get; private set; }

        /// <summary>
        /// The size of the pearls (square)
        /// </summary>
        public double PearlBeadSize { get; private set; }

        /// <summary>
        /// The acctual height (size) of the grid
        /// </summary>
        public double TotalGridHeight { get; private set; }

        /// <summary>
        /// The acctual width (size) of the grid
        /// </summary>
        public double TotalGridWidth { get; private set; }

        /// <summary>
        /// Constructor, Fetches all settings from Settings.settings
        /// </summary>
        public PearlGrid()
        {
            ItemsAccrossGridHeight = Properties.Settings.Default.GridHeightSize;
            ItemsAccrossGridWidth = Properties.Settings.Default.GridWidthSize;

            PearlBeadSize = Properties.Settings.Default.PearlSize;
            Color color = Color.FromArgb(
                Properties.Settings.Default.PearlBackgroundColor.A,
                Properties.Settings.Default.PearlBackgroundColor.R,
                Properties.Settings.Default.PearlBackgroundColor.G,
                Properties.Settings.Default.PearlBackgroundColor.B
            );
            DefaultColor = new SolidColorBrush(color);
            TotalGridHeight = PearlBeadSize * ItemsAccrossGridHeight;
            TotalGridWidth = PearlBeadSize * ItemsAccrossGridWidth;
            GeneratePearlList();
        }

        /// <summary>
        /// Overwrite Pearls with new Pearl Objects
        /// </summary>
        public void GeneratePearlList()
        {
            var pearls = new List<Pearl>();
            var items = (ItemsAccrossGridHeight * ItemsAccrossGridWidth);
            for (int i = 0; i < items; i++)
            {
                pearls.Add(new Pearl(i, DefaultColor));
            }
            Pearls = pearls;
        }
    }
}