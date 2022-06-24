using Chess.BoardGame;
using Chess.ChessGame;

namespace Chess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Screen.SetBackgroundColorForGame();
            Screen.SetFontConsole();

            try
            {
                Board board = new Board();

                board.PutPiece(new King(Color.BLACK, board), new Position(1, 2));

                board.PutPiece(new King(Color.WHITE, board), new Position(1, 3));
                board.PutPiece(new Rook(Color.WHITE, board), new Position(2, 4));
                board.PutPiece(new Rook(Color.BLACK, board), new Position(7, 4));
                board.PutPiece(new King(Color.BLACK, board), new Position(1, 2));

                var b = board.IsPieceInAValidPosition(new Position(8, 2));

                Screen.PrintBoard(board);
                Console.ReadLine();
            }
            catch(BoardException e)
            {
                Screen.SetBackgroundColorForError();
                Console.WriteLine(e.Message);
            }
        }
    }
}

