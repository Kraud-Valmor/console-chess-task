using Task.Chess.Chessmen;
using Task.Chess.Parsing;
using System;
using System.Collections.Generic;

namespace Task.Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter data in format:");
                Console.WriteLine("(Chessman name) (Chessman position) (Chessboard width with 26 max value) (Chessboard heigh with 26 max value)");
                Console.WriteLine("without brackets");

                (string error, Chessboard chessboard, Chessman chessman) = Parser.Parse(Console.ReadLine());

                if (error is null)
                {
                    if (chessman.Coords.X > chessboard.Width || chessman.Coords.Y > chessboard.Height)
                    {
                        End("You are trying to put a chessman out of chessboard =)");
                    }
                    else
                    {
                        List<Coords> moves = chessman.ValidMoves(chessboard);

                        if (moves.Count > 0)
                        {
                            foreach (Coords move in moves)
                            {
                                Console.WriteLine(move.WithLetter());
                            }
                        }
                        else
                        {
                            End("Chessman has no available moves");
                        }
                    }
                }
                else
                {
                    End(error);
                }
            }
        }

        static void End(string error)
        {
            Console.WriteLine(error);
            Console.ReadKey();
        }
    }
}