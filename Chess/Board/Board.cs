namespace Chess.Board
{
    public class Board
    {
        private int Rows { get; set; }
        private int Columns { get; set; }
        private Piece[,] _pieces;

        public Board()
        {
            Rows = 8;
            Columns = 8;
            _pieces = new Piece[Rows, Columns];
        }
    }
}
