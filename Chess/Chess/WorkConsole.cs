using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class WorkConsole
    {
        public static string SelectFigure()
        {
            Console.WriteLine("Выберете фигуру \n1.Король \n2.Ферзь \n3.Слон \n4.Конь \n5.Ладья \n6.Пешка\n");
            return Console.ReadLine();
        }

        public static void InputData(out string coordStart, out string coordEnd)
        {
            Console.WriteLine("\nВведите начальную и конечную координаты:");
            coordStart = Console.ReadLine();
            coordEnd = Console.ReadLine();
        }

        public static void ErrorOutput()
        {
            Console.WriteLine("\nОшибка! Координаты введены неверно");
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
