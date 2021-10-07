using System.Collections.Generic;

namespace Task.Chess.Chessmen
{
    public abstract class Chessman
    {
        public readonly Coords Coords;

        public Chessman(Coords coords)
        {
            Coords = coords;
        }

        public abstract List<Coords> ValidMoves(Chessboard chessboard);
    }
}