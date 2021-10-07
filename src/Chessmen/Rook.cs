using System.Collections.Generic;

namespace Task.Chess.Chessmen
{
    public class Rook : Chessman
    {
        public Rook(Coords coords) : base(coords) { }

        public override List<Coords> ValidMoves(Chessboard chessboard)
        {
            List<Coords> result = new();

            Moves.Lines(result, Coords, chessboard);

            return result;
        }
    }
}