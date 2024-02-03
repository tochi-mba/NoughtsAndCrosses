using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses
{
    internal class Board
    {

        public char[,] board;
        public Board(char[,] aBoard = null)
        {
            if (aBoard == null)
            {
                board = new char[,]  {{ '!', '!', '!'},
                                      { '!', '!', '!'},
                                      { '!', '!', '!'}};
            }
            else
            {
                board = aBoard;
            }
        }

        public bool ModifyBoard(int x, int y, char player)
        {
            if (board[x, y] != 'x' && board[x, y] != 'o')
            {
                board[x, y] = player;
                return true;
            }

            return false;
        }
       
    }
}
