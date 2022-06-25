using Chess.BoardGame;

namespace Chess.ChessGame
{
    public class ChessPosition
    {
        public char InputedColumn { get; set; }
        public int InputedRow { get; set; }

        public ChessPosition(char column, int row)
        {
            InputedColumn = column;
            InputedRow = row;
        }

        public Position GetPositionByInput()
        {
            int totalRows = 8;
            char asciiValueOfA = 'a'; //a = 97

            return new Position(totalRows - InputedRow, InputedColumn - asciiValueOfA);
        }

        public override string ToString()
        {
            return $"{InputedColumn}{InputedRow}";
        }
    }
}
