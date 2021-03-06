namespace Chess.BoardGame
{
    public abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public Board Board { get; protected set; }
        public int MoveQuantity { get; protected set; }

        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            Board = board;
            MoveQuantity = 0;
        }

        public bool ColorIsWhite(Color color) =>  color.Equals(Color.WHITE);

        public void IncrementMoveQuantity() => MoveQuantity++;

        public abstract bool[,] PossibleMoves();
    }
}
