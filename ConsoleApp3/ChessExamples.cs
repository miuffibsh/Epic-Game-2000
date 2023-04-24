using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ChessExamples
    {
        public void Chess1()
        {
            ChessPoint[] towers1 = new ChessPoint[] { new ChessPoint(3, 0), new ChessPoint(2, 2), new ChessPoint(3, 3), new ChessPoint(2, 5) };
            ChessPoint[] horses1 = new ChessPoint[] { new ChessPoint(1, 1), new ChessPoint(4, 4) };
            ChessPoint[] player1 = new ChessPoint[] { new ChessPoint(5, 5), new ChessPoint(0, 0) };
            ChessPoint[] exits1 = new ChessPoint[] { new ChessPoint(4, 0), new ChessPoint(1, 5) };
            ChessGames chessGames = new ChessGames(towers1, horses1, player1, exits1, 0, "Taras przy plaży");
        }
        
    }
}
