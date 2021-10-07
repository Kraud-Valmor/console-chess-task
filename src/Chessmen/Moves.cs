using System.Collections.Generic;

namespace Task.Chess.Chessmen
{
    public static class Moves
    {
        public static void CustomShift(List<Coords> result, Coords coords, Chessboard chessboard, int horisontalShift, int verticalShift)
        {
            Coords move = new Coords(coords.X + horisontalShift, coords.Y + verticalShift);

            if (move.IsOnBoard(chessboard))
                result.Add(move);
        }

        public static void Lines(List<Coords> result, Coords coords, Chessboard chessboard)
        {
            for (int i = 1; i <= chessboard.Width; i++)
                if (i != coords.X)
                    result.Add(new Coords(i, coords.Y));

            for (int k = 1; k <= chessboard.Height; k++)
                if (k != coords.Y)
                    result.Add(new Coords(coords.X, k));
        }

        public static void Diagonales(List<Coords> result, Coords coords, Chessboard chessboard)
        {
            bool anyResultOnBoard = true;
            int i = 1;
            
            while (anyResultOnBoard)
            {
                anyResultOnBoard = false;

                Coords topRight = new Coords(coords.X + i, coords.Y + i);
                Coords botRight = new Coords(coords.X + i, coords.Y - i);
                Coords botLeft = new Coords(coords.X - i, coords.Y - i);
                Coords topLeft = new Coords(coords.X - i, coords.Y + i);

                if (topRight.IsOnBoard(chessboard))
                {
                    anyResultOnBoard = true;
                    result.Add(topRight);
                }

                if (botRight.IsOnBoard(chessboard))
                {
                    anyResultOnBoard = true;
                    result.Add(botRight);
                }

                if (botLeft.IsOnBoard(chessboard))
                {
                    anyResultOnBoard = true;
                    result.Add(botLeft);
                }

                if (topLeft.IsOnBoard(chessboard))
                {
                    anyResultOnBoard = true;
                    result.Add(topLeft);
                }

                i++;
            }
        }
    }
}