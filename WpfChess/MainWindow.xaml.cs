using Chess;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChessDesk _desk = new ChessDesk();
        Cursor? _cursor;
        ChessPoint[] _canMove;
        bool _isFigureSelected = false;

        FigureCell? selectedFigure = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        FigureCell? getFigureCell(int x,int y)
        {
            foreach (UIElement ui in chessDesk.Children)
            {
                if (ui is FigureCell)
                {
                    int rowIndex = Grid.GetRow(ui);
                    int columnIndex = Grid.GetColumn(ui);
                    if (rowIndex-1 == y && columnIndex-1 == x)
                        return (FigureCell)ui;
                }
            }
            return null;
        }

        FigureCell? getFigureCell(ChessPoint point)=>getFigureCell(point.Row,point.Column);


        ChessPoint getFigureCellPosition(FigureCell figureCell)
        {
            int rowIndex = Grid.GetRow(figureCell);
            int columnIndex = Grid.GetColumn(figureCell);
            return new ChessPoint(columnIndex-1, rowIndex - 1);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _desk.Clear();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var cell = getFigureCell(i, j);
                    if (cell != null)
                    {
                        cell.Figure = _desk[i, j];
                        cell.MouseEnter += Cell_MouseEnter;
                        cell.MouseLeave += Cell_MouseLeave;
                        cell.MouseDown += Cell_MouseDown;
                    }
                }
            }
        }

        private void Cell_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FigureCell f = sender as FigureCell;
            if (_isFigureSelected)
            {
                _isFigureSelected = false;
                if (f != null)
                {
                    if (selectedFigure != null)
                    {
                        var destination = getFigureCellPosition(f);
                        var source = getFigureCellPosition(selectedFigure);
                        try
                        {
                            _desk.Move(source, destination);
                            
                            f.Figure = selectedFigure.Figure;
                            selectedFigure.Figure = null;
                            selectedFigure = null;

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    
                }




            }
            else
            {
                _isFigureSelected = true;
                if (f != null)
                {
                    selectedFigure = f;
                }
            }
        }

        private void Cell_MouseLeave(object sender, MouseEventArgs e)
        {
            if (_isFigureSelected) return;
            
            this.Cursor = _cursor;
                if (_canMove != null)
                {
                    foreach (var cell in _canMove)
                    {
                        var markFigure = getFigureCell(cell);
                        if (markFigure != null)
                        {
                            markFigure.IsMarkFigure = false;
                        }
                    }
                }
 
        }

        private void Cell_MouseEnter(object sender, MouseEventArgs e)
        {
            if (_isFigureSelected) return;

            FigureCell f = sender as FigureCell;
            if (f != null)
            {
                var figure = f.Figure;
                if (figure != null)
                {
                    var coords = getFigureCellPosition(f);
                    _canMove = figure.CanMove(coords, _desk).ToArray();
                    if (_canMove.Length > 0)
                    {
                        _cursor = this.Cursor;
                        this.Cursor = Cursors.Hand;
                        foreach (var cell in _canMove)
                        {
                           var markFigure =  getFigureCell(cell);
                            if (markFigure != null)
                            {
                                markFigure.IsMarkFigure = true;
                            }
                        }


                    }
                }
            }
        }
    }
}
