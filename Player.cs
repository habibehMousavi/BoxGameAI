using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketClient_2
{
    class Player
    {
        public int turn = 0;

        public Table table = new Table();

        public string getNextMove()
        {
            int[] move = new int[4];

            move = getBestMove();

            return '[' + move[0].ToString() + ',' + move[1].ToString() + ',' + move[2].ToString() + ',' + move[3].ToString() + ']';
        }

        private int[] getBestMove()
        {
            // int 4 taE az x1, y1, x2, y2

            int[] move = new int[4];

            return move;

        }
       public void setMove(move) 
        {
           /int lastMove=move;
        }

        
    }

    //tree


}
