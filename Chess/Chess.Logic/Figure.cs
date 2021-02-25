using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Figure
    {
        static bool IsKingCorrect(int[] start, int[] end)
        {
            return Math.Abs(start[0] - end[0]) <= 1 && Math.Abs(start[1] - end[1]) <= 1;
        }

        static bool IsQueenCorrect(int[] start, int[] end)
        {
            return Math.Abs(start[0] - end[0]) == Math.Abs(start[1] - end[1]) || end[0] == start[0] && end[1] != start[1] || end[0] != start[0] && end[1] == start[1];
        }

        static bool IsHorseCorrect(int[] start, int[] end)
        {
            int dx = Math.Abs(end[0] - start[0]);
            int dy = Math.Abs(end[1] - start[1]);

            return dx + dy == 3 && dx * dy == 2;
        }

        static bool IsBishopCorrect(int[] start, int[] end)
        {
            return Math.Abs(start[0] - end[0]) == Math.Abs(start[1] - end[1]);
        }

        static bool IsRookCorrect(int[] start, int[] end)
        {
            return end[0] == start[0] && end[1] != start[1] || end[0] != start[0] && end[1] == start[1];
        }

        static bool IsPawnsorrect(int[] start, int[] end)
        {
            return end[0] - start[0] == 0 && end[1] - start[1] == 1;
        }

        public static bool NewCheckIfFigure(int[] start, char[,] board)
        {
            if (board[start[0], start[1]] == ' ')
            {
                return false;
            }
            else return true;
        }

        public static bool IdentifyFigure(char[,] board, int[] start, int[] end)
        {
            bool correct = false;

            switch (board[start[0], start[1]])
            {
                case 'K':
                    correct = IsKingCorrect(start, end);
                    break;
                case 'Q':
                    correct = IsQueenCorrect(start, end);
                    break;
                case 'B':
                    correct = IsBishopCorrect(start, end);
                    break;
                case 'H':
                    correct = IsHorseCorrect(start, end);
                    break;
                case 'R':
                    correct = IsRookCorrect(start, end);
                    break;
                case 'P':
                    correct = IsPawnsorrect(start, end);
                    break;
            }
            return correct;
        }

        public static void MoveFigure(char[,] board, int[] start, int[] end)
        {
            board[end[0], end[1]] = board[start[0], start[1]];
            board[start[0], start[1]] = ' ';
        }
    }
}
