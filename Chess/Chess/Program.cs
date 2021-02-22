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

            bool correct = IsHorseCorrect(coordStartInArray, coordEndInArray);
            WorkConsole.OutputMoveResults(correct);
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
        static bool IsHorseCorrect(int[] coordStartInArray, int[] coordEndInArray)
        {
            int dx = Math.Abs(coordEndInArray[0] - coordStartInArray[0]);
            int dy = Math.Abs(coordEndInArray[1] - coordStartInArray[1]);

            return dx + dy == 3 && dx * dy == 2;
        }
    }
}
