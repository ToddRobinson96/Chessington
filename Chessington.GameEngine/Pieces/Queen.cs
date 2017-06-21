using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
			List<Square> availableMoves = new List<Square>();
	        for (var i = 0; i < 8; i++)
	        {
		        availableMoves.Add(Square.At(board.FindPiece(this).Row, i));
	        }
	        for (var i = 0; i < 8; i++)
	        {
		        availableMoves.Add(Square.At(i, board.FindPiece(this).Col));
	        }
	        for (int i = -7; i < 8; i++)
	        {
		        if (board.FindPiece(this).Row + i < 8 && board.FindPiece(this).Col + i < 8 &&
		            board.FindPiece(this).Row + i >= 0 && board.FindPiece(this).Col + i >= 0)
		        {
			        availableMoves.Add(Square.At(board.FindPiece(this).Row + i, board.FindPiece(this).Col + i));
		        }
	        }
	        for (int i = -7; i < 8; i++)
	        {
		        if (board.FindPiece(this).Row - i < 8 && board.FindPiece(this).Col + i < 8 &&
		            board.FindPiece(this).Row - i >= 0 && board.FindPiece(this).Col + i >= 0)
		        {
			        availableMoves.Add(Square.At(board.FindPiece(this).Row - i, board.FindPiece(this).Col + i));
		        }
	        }
	        availableMoves.RemoveAll(item => item == Square.At(board.FindPiece(this).Row, board.FindPiece(this).Col));
			return availableMoves;
        }
    }
}