using Task.Chess.Chessmen;

namespace Task.Chess.Parsing
{
    static class Parser
    {
        public static (string error, Chessboard, Chessman) Parse(string input)
        {
            string[] textArray = input.Split(' ');

            if (textArray.Length != 4)
                return ("Invalid number of arguments", null, null);
            
            int coordX = textArray[1][0] - 'a' + 1;

            if (coordX < 1 || coordX > 26)
                return ("File of chessman position invalid format", null, null);    

            if (!int.TryParse(textArray[1][1..], out int coordY))
                return ("Rank of chessman position invalid format", null, null);

            Coords coords = new Coords(coordX, coordY);

            Chessman chessman = textArray[0] switch
            {
                "king"      => new King(coords),
                "queen"     => new Queen(coords),
                "rook"      => new Rook(coords),
                "bishop"    => new Bishop(coords),
                "knight"    => new Knight(coords),
                "pawn"      => new Pawn(coords),
                _           => null
            };
            
            if (chessman is null)
                return ("Invalid chessman name", null, null);

            if (!int.TryParse(textArray[2], out int width) || width < 1 || width > 26)
                return ("Chessboard width invalid format", null, null);

            if (!int.TryParse(textArray[3], out int height) || height < 1 || height > 26)
                return ("Chessboard height invalid format", null, null);

            return (null, new Chessboard(width, height), chessman);
        }
    }
}