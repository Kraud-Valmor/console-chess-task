using System.Collections.Generic;

namespace Task.Chess.Chessmen
{
    public class Pawn : Chessman
    {
        public Pawn(Coords coords) : base(coords) { }

        public override List<Coords> ValidMoves(Chessboard chessboard)
        {
            List<Coords> result = new();

            Moves.CustomShift(result, Coords, chessboard, 0, 1);
            
            return result;
        }
    }
}