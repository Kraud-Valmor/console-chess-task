using System.Collections.Generic;

namespace Task.Chess.Chessmen
{
    public class King : Chessman
    {
        public King(Coords coords) : base(coords) { }

        public override List<Coords> ValidMoves(Chessboard chessboard)
        {
            List<Coords> result = new List<Coords>();

            Moves.CustomShift(result, Coords, chessboard, 0, 1);
            Moves.CustomShift(result, Coords, chessboard, 1, 1);
            Moves.CustomShift(result, Coords, chessboard, 1, 0);
            Moves.CustomShift(result, Coords, chessboard, 1, -1);
            Moves.CustomShift(result, Coords, chessboard, 0, -1);
            Moves.CustomShift(result, Coords, chessboard, -1, -1);
            Moves.CustomShift(result, Coords, chessboard, -1, 0);
            Moves.CustomShift(result, Coords, chessboard, -1, 1);

            return result;
        }
    }
}