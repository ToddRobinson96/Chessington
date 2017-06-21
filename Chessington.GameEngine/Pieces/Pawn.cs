using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
	        if (Player == Player.Black)
	        {
		        if (board.FindPiece(this).Row == 1)
		        {
			        if (board.GetPiece(Square.At(board.FindPiece(this).Row + 2, board.FindPiece(this).Col)) == null && board.GetPiece(Square.At(board.FindPiece(this).Row + 1, board.FindPiece(this).Col)) == null)
			        {
				        availableMoves.Add(Square.At(board.FindPiece(this).Row + 2, board.FindPiece(this).Col));
			        }
		        }
		        if (board.GetPiece(Square.At(board.FindPiece(this).Row + 1, board.FindPiece(this).Col)) == null)
		        {
			        availableMoves.Add(Square.At(board.FindPiece(this).Row + 1, board.FindPiece(this).Col));
		        }
		        return availableMoves;
	        }
	        else
	        {
				if (board.FindPiece(this).Row == 7)
		        {
			        if (board.GetPiece(Square.At(board.FindPiece(this).Row - 2, board.FindPiece(this).Col)) == null && board.GetPiece(Square.At(board.FindPiece(this).Row - 1, board.FindPiece(this).Col)) == null)
			        {
				        availableMoves.Add(Square.At(board.FindPiece(this).Row - 2, board.FindPiece(this).Col));
			        }
		        }
		        if (board.GetPiece(Square.At(board.FindPiece(this).Row - 1, board.FindPiece(this).Col)) == null)
		        {
			        availableMoves.Add(Square.At(board.FindPiece(this).Row - 1, board.FindPiece(this).Col));
		        }
		        return availableMoves;
			}
	        
		}
    }
}