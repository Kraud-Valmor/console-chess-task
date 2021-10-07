using System.Collections.Generic;

namespace Task.Chess.Chessmen
{
    public class Bishop : Chessman
    {
        public Bishop(Coords coords) : base(coords) { }

        public override List<Coords> ValidMoves(Chessboard chessboard)
        {
            List<Coords> result = new();

            Moves.Diagonales(result, Coords, chessboard);

            return result;
        }
    }
}