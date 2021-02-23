using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordStart;
            string coordEnd;
            WorkConsole.InputData(out coordStart, out coordEnd);

            int[] coordStartInArray = SplitCoordHorizontAndVertical(coordStart);
            int[] coordEndInArray = SplitCoordHorizontAndVertical(coordEnd);

            if (!CheckCoord(coordStartInArray) && !CheckCoord(coordEndInArray))
            {
                WorkConsole.ErrorOutput();
            }

            char[,] board = Board.CreateBoard();

            CheckIfFigure(coordStartInArray, coordEndInArray, board);

            if (IdentifyFigure(board, coordStartInArray, coordEndInArray))
            {
                MoveFigure(board, coordStartInArray, coordEndInArray);
            }
            else
            {
                WorkConsole.ErrorOutput();
            }

        }
        static int[] SplitCoordHorizontAndVertical(string coord)
        {
            int horizontCoord = coord[0] - 64;
            int verticalCoord = Convert.ToInt32(coord[1] - 48);

            int[] coordInArray = new int[] { horizontCoord, verticalCoord };
            return coordInArray;
        }

        static bool CheckCoord(int[] coord)
        {
            if (coord[0] < 9 && coord[0] > 0 && coord[1] < 9 && coord[1] > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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

        static void CheckIfFigure(int[] start, int[] end, char[,] board)
        {
            if (board[start[0] - 1, start[1] - 1] == ' ')
            {
                WorkConsole.ErrorOutput();
            }
        }

        static bool IdentifyFigure(char[,] board, int[] start, int[] end)
        {
            bool correct = false;

            switch ( board[start[0] - 1, start[1] - 1] )
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

        static void MoveFigure(char[,] board, int[] start, int[] end)
        {
            board[end[0] - 1, end[1] - 1] = board[start[0] - 1, start[1] - 1];
            board[start[0] - 1, start[1] - 1] = ' ';
        }
    }
}
