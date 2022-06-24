using Chess.BoardGame;

namespace Chess
{
    public class Screen
    {
        public static void SetFontConsole() => Console.OutputEncoding = System.Text.Encoding.UTF8;
        public static void PrintBoard(Board board)
        {

            for (int i = 0; i < board.Rows; i++)
            {
                for(int j = 0; j < board.Columns; j++)
                {
                    Console.Write(board._pieces[i, j]?.ToString() ?? " - ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
