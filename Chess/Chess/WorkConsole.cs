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
    }
}
