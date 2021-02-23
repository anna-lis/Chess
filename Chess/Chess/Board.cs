using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Board
    {
        public static void CreateBoard()
        {
            char[,] board = { { 'R', 'H', 'B', 'Q', 'K', 'B', 'H', 'R' },
                              { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                              { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                              { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                              { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                              { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                              { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                              { 'R', 'H', 'B', 'Q', 'K', 'B', 'H', 'R' } }; 
             
        }
    }
}
