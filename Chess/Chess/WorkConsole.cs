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
    }
}
