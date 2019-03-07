using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PearlsDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Rectangle> Rectangles = new List<Rectangle>();

        public MainWindow()
        {
            InitializeComponent();
            //this.PearlGrid.set
            //< Rectangle Fill = "#FFF4F4F5" HorizontalAlignment = "Left" Height = "15" Width = "15" Margin = "1" Stroke = "Black" VerticalAlignment = "Top" />
                        
            PearlGrid grid = new PearlGrid()
            {
                PearlBeadSize = 15,
                Pearls = new List<Pearl>()
                {
                    new Pearl(1, Colors.Aqua),
                    new Pearl(2, Colors.Beige),
                    new Pearl(3, Colors.Black)
                }
            };

            Rectangles = new List<Rectangle>();
        }

        public void GeneratePearlCanvas(PearlGrid pearlGrid)
        {
            List<Rectangle> tmp_rectangles = new List<Rectangle>();
            foreach (var pearl in pearlGrid.Pearls)
            {
                tmp_rectangles.Add(new Rectangle()
                {
                    Fill = Brushes.Aqua,
                    //Stroke = Brushes.Black,
                    Height = pearlGrid.PearlBeadSize,
                    Width = pearlGrid.PearlBeadSize,
                    Margin = new Thickness(1)
                });
            }

            Rectangles.AddRange(tmp_rectangles);
        }
    }

    public class Pearl
    {
        public Pearl(int id, Color color)
        {
            Id = id;
            Color = color;
        }

        public int Id { get; set; }
        public Color Color { get; set; }
    }

    public class PearlGrid
    {
        Color defaultColor = Colors.White;
        public int PearlGridSize { get; set; }
        public double PearlBeadSize { get; set; }
        public Color DefaultColor { get => defaultColor; set => defaultColor = value; }

        public List<Pearl> Pearls = new List<Pearl>();
    }
}
