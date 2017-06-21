using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

	    public override IEnumerable<Square> GetAvailableMoves(Board board)
	    {
		    List<Square> availableMoves = new List<Square>();

		    int leftLim = ;
			for (int i=0; board.GetPiece(Square.At(board.FindPiece(this).Row, i)) == null; i++)



			for (var i = 0; i < 8; i++)
			{
				availableMoves.Add(Square.At(board.FindPiece(this).Row,i));
	        }
	        for (var i = 0; i < 8; i++)
	        {
		        availableMoves.Add(Square.At(i,board.FindPiece(this).Col));
	        }
	        return availableMoves;
        }
    }
}