using Chess.BoardGame;

namespace Chess.ChessGame
{
    public class Rook : Piece
    {
        public Rook(Color color, Board board) : base(color, board){}

        public override string ToString()
        {
            return ColorIsWhite(Color) ? " \u2656 " : "\u265c";
        }
    }
}
