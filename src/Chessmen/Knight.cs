using System.Collections.Generic;

namespace Task.Chess.Chessmen
{
    public class Knight : Chessman
    {
        public Knight(Coords coords) : base(coords) { }

        public override List<Coords> ValidMoves(Chessboard chessboard)
        {
            List<Coords> result = new();

            Moves.CustomShift(result, Coords, chessboard, 1, 2);
            Moves.CustomShift(result, Coords, chessboard, 2, 1);
            Moves.CustomShift(result, Coords, chessboard, 2, -1);
            Moves.CustomShift(result, Coords, chessboard, 1, -2);
            Moves.CustomShift(result, Coords, chessboard, -1, -2);
            Moves.CustomShift(result, Coords, chessboard, -2, -1);
            Moves.CustomShift(result, Coords, chessboard, -2, 1);
            Moves.CustomShift(result, Coords, chessboard, -1, 2);

            return result;
        }
    }
}