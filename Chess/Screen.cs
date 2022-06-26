using Chess.BoardGame;
using Chess.ChessGame;

namespace Chess
{
    public class Screen
    {
        public static void SetFontConsole() => Console.OutputEncoding = System.Text.Encoding.UTF8;
        private static void PrintColumnNumbers(int rows, int i) => Console.Write($"{rows - i} ");
        private static void PrintRowLetters() => Console.WriteLine("   a  b  c  d  e  f  g  h");

        public static void PrintBoard(Board board)
        {

            for (int i = 0; i < board.Rows; i++)
            {
                PrintColumnNumbers(board.Rows, i);

                for (int j = 0; j < board.Columns; j++)
                {
                    Console.Write(board._pieces[i, j]?.ToString() ?? " - ");
                }
                Console.WriteLine();
            }
            PrintRowLetters();
        }

        public static ChessPosition ReadChessPosition()
        {
            string inputValue = Console.ReadLine();
            char column = inputValue.ToCharArray(0, 1)[0];
            int row = int.Parse(inputValue.Substring(1, 1));
            return new ChessPosition(column, row);
        }

    }
}
