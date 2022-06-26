using Chess.BoardGame;
using Chess.ChessGame;

namespace Chess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Screen.SetFontConsole();

            try
            {
                ChessMatch match = new ChessMatch();

                while(!match.finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.board);

                    Console.Write("origem");
                    Position source = Screen.ReadChessPosition().GetPositionByInput();

                    Console.Write("destino");
                    Position target = Screen.ReadChessPosition().GetPositionByInput();

                    match.MakeMove(source, target);

                }
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

