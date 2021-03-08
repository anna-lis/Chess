using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = Board.CreateBoard(); //love

            int[] coordSelectCell = { 1, 1 };
            int[] pastCoordSelectCell = { 1, 1 };

            while (true)
            {
                WorkConsole.ClearConsole();
                WorkConsole.DrawBoard(board);

                string[] movementOfFigure = new string[2];
                WorkConsole.CellNavigation(coordSelectCell, pastCoordSelectCell, board, movementOfFigure);

                int[] coordStartInArray = SplitCoordHorizontAndVertical(movementOfFigure[0]);
                int[] coordEndInArray = SplitCoordHorizontAndVertical(movementOfFigure[1]);

                if (!CheckCoord(coordStartInArray) && !CheckCoord(coordEndInArray))
                {
                    WorkConsole.ErrorOutput();
                }

                CheckIfFigure(coordStartInArray, board);

                if (Figure.IdentifyFigure(board, coordStartInArray, coordEndInArray))
                {
                    Figure.MoveFigure(board, coordStartInArray, coordEndInArray);
                }
                else
                {
                    WorkConsole.ErrorOutput();
                }
            }
        }

        public static int[] SplitCoordHorizontAndVertical(string coord)
        {
            int horizontCoord = coord[0] - 48;
            int verticalCoord = Convert.ToInt32(coord[1] - 48);

            int[] coordInArray = new int[] { horizontCoord, verticalCoord };
            return coordInArray;
        }

        public static bool CheckCoord(int[] coord)
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

        public static void CheckIfFigure(int[] start, char[,] board)
        {
            if (board[start[0], start[1]] == ' ')
            {
                WorkConsole.ErrorOutput();
            }
        }
    }
}
