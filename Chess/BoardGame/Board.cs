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
            if (IsPieceInAInvalidPosition(position)) 
                throw new BoardException($"There is already a piece on position: {position}");

            piece.Position = position;
            _pieces[position.Row, position.Column] = piece;
        }

        public Piece GetPieceByPosition(Position position)
        {
            return _pieces[position.Row, position.Column];
        }

        public bool IsValidPosition(Position position)
        {
            return position.Row >= 0
                && position.Row < Rows
                && position.Column  >= 0
                && position.Column < Columns;
        }

        public bool IsPieceInAInvalidPosition(Position position)
        {
            if (!IsValidPosition(position)) throw new BoardException("Invalid position!");

            return GetPieceByPosition(position) != null;
        }
    }
}
