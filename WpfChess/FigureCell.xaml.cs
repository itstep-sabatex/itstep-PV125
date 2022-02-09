using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfChess
{
    /// <summary>
    /// Interaction logic for FigureCell.xaml
    /// </summary>
    public partial class FigureCell : UserControl
    {
        BitmapImage ByteArrayToBitmapImage(Byte[] bytes)
        {
            var stream = new MemoryStream(bytes);
            stream.Seek(0, SeekOrigin.Begin);
            var image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }

        BitmapImage? getImmage(Figure? figure)
        {
            if (figure == null) return null;

            return ByteArrayToBitmapImage(FigureImages.PawnWhite);
        }

        Figure? _figure = null;
        public Figure? Figure 
        { 
            get=>_figure;
            set 
            {
                _figure = value;
                figure.Source = getImmage(value);
            }
        }  

        public FigureCell()
        {
            InitializeComponent();
        }
    }
}
