using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
	        yield return Square.At(board.FindPiece(this).Row + 1, board.FindPiece(this).Col + 2);
	        yield return Square.At(board.FindPiece(this).Row - 1, board.FindPiece(this).Col + 2);
	        yield return Square.At(board.FindPiece(this).Row + 1, board.FindPiece(this).Col - 2);
	        yield return Square.At(board.FindPiece(this).Row - 1, board.FindPiece(this).Col - 2);
	        yield return Square.At(board.FindPiece(this).Row + 2, board.FindPiece(this).Col + 1);
	        yield return Square.At(board.FindPiece(this).Row - 2, board.FindPiece(this).Col + 1);
	        yield return Square.At(board.FindPiece(this).Row + 2, board.FindPiece(this).Col - 1);
	        yield return Square.At(board.FindPiece(this).Row - 2, board.FindPiece(this).Col - 1);
		}
    }
}