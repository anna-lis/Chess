using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class WorkConsole
    {
        public static void InputData(out string coordStart, out string coordEnd)
        {
            Console.WriteLine("\nВведите начальную и конечную координаты:");

            coordStart = Console.ReadLine();
            coordEnd = Console.ReadLine();
        }

        public static void ErrorOutput()
        {
            Console.WriteLine("\nОшибка!");
        }

        public static void OutputMoveResults(bool correct)
        {
            if (correct)
            {
                Console.WriteLine("\nХод фигуры верный!");
            }
            else 
            {
                Console.WriteLine("\nХод фигуры неверный!");
            }
        }

        public static void DrawBoard(char[,] board)
        {
            int x = 8;
            int y = 8;

            DrawFirstLine(x, "┌", "─", "┬", "┐");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"│ {board[j,i]} ");
                }

                Console.WriteLine("│");
                DrawFirstLine(x, "├", "─", "┼", "┤");
            }

            Console.SetCursorPosition(0, 16);
            DrawFirstLine(x, "└", "─", "┴", "┘");
        }

        public static void DrawFirstLine(int x, string oneChar, string twoChar, string freeChar, string fourChar)
        {
            Console.Write($"{oneChar}{twoChar}{twoChar}{twoChar}");

            for (int i = 0; i < x - 1; i++)
            {
                Console.Write($"{freeChar}{twoChar}{twoChar}{twoChar}");
            }

            Console.WriteLine($"{fourChar}");
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void ChooseCell(int[] coordSelectCell, int[] pastCoordSelectCell, char[,] board)
        {
            Console.SetCursorPosition(pastCoordSelectCell[0] * 4 + 2, pastCoordSelectCell[1] * 2 + 1);
            char pastSelectFigure = board[pastCoordSelectCell[0], pastCoordSelectCell[1]];

            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write($"{pastSelectFigure}");
            Console.ResetColor();

            Console.SetCursorPosition(coordSelectCell[0] * 4 + 2, coordSelectCell[1] * 2 + 1);
            char selectFigure = board[coordSelectCell[0], coordSelectCell[1]];

            Console.BackgroundColor = ConsoleColor.DarkYellow;

            Console.Write($"{selectFigure}");
            Console.ResetColor();

            pastCoordSelectCell[0] = coordSelectCell[0];
            pastCoordSelectCell[1] = coordSelectCell[1];
        }

        public static void CellNavigation(int[] coordSelectCell, int[] pastCoordSelectCell, char[,] board, string[] movementOfFigure)
        {
            bool isTheFigureSelected = true;

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;

                if ((key == ConsoleKey.DownArrow) && (coordSelectCell[1] < 7))
                    coordSelectCell[1]++;

                if ((key == ConsoleKey.UpArrow) && (coordSelectCell[1] > 0))
                    coordSelectCell[1]--;

                if ((key == ConsoleKey.RightArrow) && (coordSelectCell[0] < 7))
                    coordSelectCell[0]++;

                if ((key == ConsoleKey.LeftArrow) && (coordSelectCell[0] > 0))
                    coordSelectCell[0]--;

                ChooseCell(coordSelectCell, pastCoordSelectCell, board);

                if ((key == ConsoleKey.Enter) && (!isTheFigureSelected))
                {
                    movementOfFigure[1] = $"{coordSelectCell[0]}{coordSelectCell[1]}";
                    break;
                }

                if ((key == ConsoleKey.Enter) && (isTheFigureSelected) && (Figure.NewCheckIfFigure(coordSelectCell, board)))
                {
                    movementOfFigure[0] = $"{coordSelectCell[0]}{coordSelectCell[1]}";
                    isTheFigureSelected = false;
                }
            }
        }
    }
}
