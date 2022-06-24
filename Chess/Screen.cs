using Chess.BoardGame;

namespace Chess
{
    public class Screen
    {
        public static void SetBackgroundColorForGame() => Console.BackgroundColor = ConsoleColor.Gray;
        public static void SetBackgroundColorForError() => Console.BackgroundColor = ConsoleColor.Black;
        public static void SetFontConsole() => Console.OutputEncoding = System.Text.Encoding.UTF8;
        public static void PrintBoard(Board board)
        {

            for (int i = 0; i < board.Rows; i++)
            {
                for(int j = 0; j < board.Columns; j++)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(board._pieces[i, j]?.ToString() ?? " - ");
                    Console.ForegroundColor = aux;
                    
                }
                Console.WriteLine();
            }
        }
    }
}
