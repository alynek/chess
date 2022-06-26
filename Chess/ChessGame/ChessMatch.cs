using Chess.BoardGame;

namespace Chess.ChessGame
{
    public class ChessMatch
    {
        public Board board { get; private set; }
        public bool finished { get; private set; }
        private int _turn;
        private Color _currentPlayer;

        public ChessMatch()
        {
            board = new Board();
            _turn = 1;
            _currentPlayer = Color.WHITE;
            finished = false;
            PutPieces();
        }

        private void PutPieces()
        {
            board.PutPiece(new King(Color.BLACK, board), new ChessPosition('b', 2).GetPositionByInput());
            board.PutPiece(new King(Color.WHITE, board), new ChessPosition('c', 1).GetPositionByInput());
            board.PutPiece(new Rook(Color.WHITE, board), new ChessPosition('h', 1).GetPositionByInput());
        }

        public void MakeMove(Position source, Position target)
        {
            Piece piece = board.RemovePiece(source);
            piece.IncrementMoveQuantity();

            Piece capturedPiece = board.RemovePiece(target);
            board.PutPiece(piece, target);
        }
    }
}
