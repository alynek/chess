namespace Chess.BoardGame
{
    public class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Piece[,] _pieces { get; private set; }

        public Board()
        {
            Rows = 8;
            Columns = 8;
            _pieces = new Piece[Rows, Columns];
        }

        public void PutPiece(Piece piece, Position position)
        {
            piece.Position = position;
            _pieces[position.Row, position.Column] = piece;
        }
    }
}
