using Chess.BoardGame;
using Chess.ChessGame;

namespace Chess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Screen.SetBackgroundColorConsole();
            Screen.SetFontConsole();

            Board board = new Board();

            board.PutPiece(new King(Color.BLACK, board), new Position(1, 2));
            board.PutPiece(new Rook(Color.WHITE, board), new Position(2, 4));

            Screen.PrintBoard(board);
            Console.ReadLine();
        }
    }
}

