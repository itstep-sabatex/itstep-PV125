using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class ChessDesk
    {
        Figure[,] _figures = new Figure[8, 8];
        
        public List<Figure> KilledFigures { get;} = new List<Figure> { };
        
        public void Clear()
        {
            for (var row = 2;row < 6; row++)
            {
                for (var column = 0; column < 8; column++) 
                {
                    _figures[row, column] = null;
                }
            }
            // pawn
            for (var column = 0; column < 8; column++)
            {
                _figures[1,column] = new Pawn(FigureColor.Black);
                _figures[6, column] = new Pawn(FigureColor.White);
            }
            // rook
            _figures[0,0] = new Rock(FigureColor.Black);
            _figures[0,7] = new Rock(FigureColor.Black);
            _figures[7,0] = new Rock(FigureColor.White);
            _figures[7,7] = new Rock(FigureColor.White);

            _figures[0,1] = new Horse(FigureColor.Black);
            _figures[0,6] = new Horse(FigureColor.Black);
            _figures[7,1] = new Horse(FigureColor.White );
            _figures[7,6] = new Horse(FigureColor.White);

            _figures[0,2] = new Bishop(FigureColor.Black );
            _figures[0,5] = new Bishop(FigureColor.Black);
            _figures[7,2] = new Bishop(FigureColor.White );
            _figures[7,5] = new Bishop(FigureColor.White);

            _figures[0,3] = new King(FigureColor.Black );
            _figures[0,4] = new Queen(FigureColor.Black );
            _figures[7,3] = new King(FigureColor.White );
            _figures[7,4] = new Queen(FigureColor.White );


        }

        public Figure this[int row, int column]
        {
            get=>_figures[row, column];
        }

        public Figure this[ChessPoint point]
        {
            get => _figures[point.Row, point.Column];
        }

        public FigureColor ActiveColor { get; set; }
        public void Move(ChessPoint source, ChessPoint destination)
        {
            var figure = _figures[source.Row, source.Column];
            if (figure == null)
                throw new Exception($"Figure not found in ({source.Row}.{source.Column}) ");
            if (figure.FigureColor != ActiveColor)
                throw new Exception($"Must be move figure color - {ActiveColor}");
            if (!figure.CheckMove(source, destination, this))
                throw new Exception("Figure can't move to position");
            var destinationFigure = _figures[destination.Row, destination.Column];
            if (destinationFigure != null)
            {
                KilledFigures.Add(destinationFigure);
            }
            figure.IsFirstMove = false;
            _figures[destination.Row, destination.Column] = figure;
            _figures[source.Row, source.Column] = null;
            ActiveColor = ActiveColor == FigureColor.Black?FigureColor.White:FigureColor.Black;

        }

    }
}
