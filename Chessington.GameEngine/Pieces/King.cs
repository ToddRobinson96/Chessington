using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
	        yield return Square.At(board.FindPiece(this).Row + 1, board.FindPiece(this).Col);
	        yield return Square.At(board.FindPiece(this).Row - 1, board.FindPiece(this).Col);
	        yield return Square.At(board.FindPiece(this).Row, board.FindPiece(this).Col + 1);
	        yield return Square.At(board.FindPiece(this).Row, board.FindPiece(this).Col - 1);
	        yield return Square.At(board.FindPiece(this).Row + 1, board.FindPiece(this).Col + 1);
	        yield return Square.At(board.FindPiece(this).Row - 1, board.FindPiece(this).Col + 1);
	        yield return Square.At(board.FindPiece(this).Row + 1, board.FindPiece(this).Col - 1);
	        yield return Square.At(board.FindPiece(this).Row - 1, board.FindPiece(this).Col - 1);
		}
    }
}