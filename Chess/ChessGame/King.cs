using Chess.BoardGame;

namespace Chess.ChessGame
{
    public class King : Piece
    {
        public King(Color color, Board board) : base(color, board){}

        public override string ToString()
        {
            return ColorIsWhite(Color) ? " \u2654 " : " \u265a ";
        }
    }
}
