using Chess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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


        public readonly static DependencyProperty IsMarkFigureProperty = 
            DependencyProperty.Register(nameof(IsMarkFigure), typeof(bool), typeof(FigureCell), new PropertyMetadata(false));
        public bool IsMarkFigure 
        {
            get=>(bool)GetValue(IsMarkFigureProperty);
            set=>SetValue(IsMarkFigureProperty,value);
        }


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
            switch (figure.FigureOrder)
            {
                case 0: return figure.FigureColor == FigureColor.White ? ByteArrayToBitmapImage(FigureImages.KingWhite) : ByteArrayToBitmapImage(FigureImages.KingBlack);
                case 1: return figure.FigureColor == FigureColor.White? ByteArrayToBitmapImage(FigureImages.PawnWhite): ByteArrayToBitmapImage(FigureImages.PawnBlack);
                case 2: return figure.FigureColor == FigureColor.White ? ByteArrayToBitmapImage(FigureImages.BishopWhite) : ByteArrayToBitmapImage(FigureImages.BishopBlack);
                case 3: return figure.FigureColor == FigureColor.White ? ByteArrayToBitmapImage(FigureImages.HourseWhite) : ByteArrayToBitmapImage(FigureImages.HourseBlack);
                case 4: return figure.FigureColor == FigureColor.White ? ByteArrayToBitmapImage(FigureImages.RockWhite) : ByteArrayToBitmapImage(FigureImages.RockBlack);
                case 5: return figure.FigureColor == FigureColor.White ? ByteArrayToBitmapImage(FigureImages.QueenWhite) : ByteArrayToBitmapImage(FigureImages.QueenBlack);


            }

            return null;
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
