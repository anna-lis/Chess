using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Board
    {
        public static char[,] CreateBoard()
        {
            char[,] board = { { 'R', 'P', ' ', ' ', ' ', ' ', 'P', 'R' },
                              { 'H', 'P', ' ', ' ', ' ', ' ', 'P', 'H' },
                              { 'B', 'P', ' ', ' ', ' ', ' ', 'P', 'B' },
                              { 'Q', 'P', ' ', ' ', ' ', ' ', 'P', 'Q' },
                              { 'K', 'P', ' ', ' ', ' ', ' ', 'P', 'K' },
                              { 'B', 'P', ' ', ' ', ' ', ' ', 'P', 'B' },
                              { 'H', 'P', ' ', ' ', ' ', ' ', 'P', 'H' },
                              { 'R', 'P', ' ', ' ', ' ', ' ', 'P', 'R' } };
            return board;
        }
    }
}
