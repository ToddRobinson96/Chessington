using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
	        List<Square> availableMoves = new List<Square>();
			for (int i=-7; i<8;i++)
	        {
		        if (board.FindPiece(this).Row + i < 8 && board.FindPiece(this).Col + i < 8 &&
		            board.FindPiece(this).Row + i >= 0 && board.FindPiece(this).Col + i >= 0 && i != 0)
		        {
			        availableMoves.Add(Square.At(board.FindPiece(this).Row + i, board.FindPiece(this).Col + i));
		        }
	        }
	        for (int i = -7; i < 8; i++)
	        {
		        if (board.FindPiece(this).Row - i < 8 && board.FindPiece(this).Col + i < 8 &&
		            board.FindPiece(this).Row - i >= 0 && board.FindPiece(this).Col + i >= 0 && i != 0)
		        {
			        availableMoves.Add(Square.At(board.FindPiece(this).Row - i, board.FindPiece(this).Col + i));
		        }
	        }
			return availableMoves;
        }
    }
}