using Chess.BoardGame;

namespace Chess.ChessGame
{
    public class King : Piece
    {
        public King(Color color, Board board) : base(color, board){}

        public override bool[,] PossibleMoves()
        {
            bool[,] mat = new bool[Board.Rows, Board.Columns];
            Position pos = new Position(0, 0);

            //up
            pos.SetValues(Position.Row - 1, Position.Column);
            if (canMove(pos) && Board.IsValidPosition(pos)) mat[pos.Row, pos.Column] = true;

            //right up diagonal
            pos.SetValues(Position.Row - 1, Position.Column + 1);
            if (canMove(pos) && Board.IsValidPosition(pos)) mat[pos.Row, pos.Column] = true;

            //right
            pos.SetValues(Position.Row, Position.Column + 1);
            if (canMove(pos) && Board.IsValidPosition(pos)) mat[pos.Row, pos.Column] = true;

            //right down diagonal
            pos.SetValues(Position.Row + 1, Position.Column + 1);
            if (canMove(pos) && Board.IsValidPosition(pos)) mat[pos.Row, pos.Column] = true;

            //down
            pos.SetValues(Position.Row + 1, Position.Column);
            if (canMove(pos) && Board.IsValidPosition(pos)) mat[pos.Row, pos.Column] = true;

            //left down diagonal
            pos.SetValues(Position.Row + 1, Position.Column - 1);
            if (canMove(pos) && Board.IsValidPosition(pos)) mat[pos.Row, pos.Column] = true;

            //left
            pos.SetValues(Position.Row, Position.Column - 1);
            if (canMove(pos) && Board.IsValidPosition(pos)) mat[pos.Row, pos.Column] = true;

            //left up diagonal
            pos.SetValues(Position.Row - 1, Position.Column - 1);
            if (canMove(pos) && Board.IsValidPosition(pos)) mat[pos.Row, pos.Column] = true;

            return mat;
        }

        private bool canMove(Position pos)
        {
            Piece p = Board.GetPieceByPosition(pos);
            return p is null || p.Color != Color;
        }

        public override string ToString()
        {
            return ColorIsWhite(Color) ? " \u2654 " : " \u265a ";
        }
    }
}
 