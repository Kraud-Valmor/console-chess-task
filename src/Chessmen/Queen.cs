using System.Collections.Generic;

namespace Task.Chess.Chessmen
{
    public class Queen : Chessman
    {
        public Queen(Coords coords) : base(coords) { }

        public override List<Coords> ValidMoves(Chessboard chessboard)
        {
            List<Coords> result = new();

            Moves.Lines(result, Coords, chessboard);
            Moves.Diagonales(result, Coords, chessboard);

            return result;
        }
    }
}