namespace Task.Chess
{
    public struct Coords
    {
        private static readonly char[] Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public readonly int X;
        public readonly int Y;

        public Coords(int x, int y) =>
            (X, Y) = (x, y);

        public string WithLetter()
        {
            return Alphabet[X - 1] + Y.ToString();
        }

        public bool IsOnBoard(Chessboard chessboard)
        {
            return X > 0 && X <= chessboard.Width && Y > 0 && Y <= chessboard.Height;
        }
    }
}