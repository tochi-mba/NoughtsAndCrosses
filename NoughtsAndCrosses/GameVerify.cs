using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses
{
    internal class GameVerify
    {
        public char Verify(char[,] board)
        {
            bool solution1 = board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2];
            bool solution2 = board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2];
            bool solution3 = board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2];

            bool solution4 = board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0];
            bool solution5 = board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1];
            bool solution6 = board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2];

            bool solution7 = board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2];
            bool solution8 = board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0];

            if (solution1)
            {
                if (board[0, 0] == 'x')
                {
                    return 'x';
                }
                else if (board[0, 0] == 'o')
                {
                    return 'o';
                }
                else
                {
                    return '!';
                }
            }
            else if (solution2)
            {
                if (board[1, 0] == 'x')
                {
                    return 'x';
                }
                else if (board[1, 0] == 'o')
                {
                    return 'o';
                }
                else
                {
                    return '!';
                }
            }
            else if (solution3)
            {
                if (board[2, 0] == 'x')
                {
                    return 'x';
                }
                else if (board[2, 0] == 'o')
                {
                    return 'o';
                }
                else
                {
                    return '!';
                }
            }
            else if (solution4)
            {
                if (board[0, 0] == 'x')
                {
                    return 'x';
                }
                else if (board[0, 0] == 'o')
                {
                    return 'o';
                }
                else
                {
                    return '!';
                }
            }
            else if (solution5)
            {
                if (board[0, 1] == 'x')
                {
                    return 'x';
                }
                else if (board[0, 1] == 'o')
                {
                    return 'o';
                }
                else
                {
                    return '!';
                }
            }
            else if (solution6)
            {
                if (board[0, 2] == 'x')
                {
                    return 'x';
                }
                else if (board[0, 2] == 'o')
                {
                    return 'o';
                }
                else
                {
                    return '!';
                }
            }
            else if (solution7)
            {
                if (board[0, 0] == 'x')
                {
                    return 'x';
                }
                else if (board[0, 0] == 'o')
                {
                    return 'o';
                }
                else
                {
                    return '!';
                }
            }
            else if (solution8)
            {
                if (board[0, 2] == 'x')
                {
                    return 'x';
                }
                else if (board[0, 2] == 'o')
                {
                    return 'o';
                }
                else
                {
                    return '!';
                }
            }

            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    if ((board[i, x] == '!'))
                    {
                        return '!';

                    }
                }
            }

            return '1';
        }

        public char currentPlayer(char player)
        {
            if (player == 'x')
            {
                return 'o';
            }
            else
            {
                return 'x';
            }
        }
    }
}
