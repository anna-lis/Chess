using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class WorkConsole
    {
        public static void InputData(out string coordStart, out string coordEnd)
        {
            Console.WriteLine("Введите начальную и конечную координаты:");
            coordStart = Console.ReadLine();
            coordEnd = Console.ReadLine();
        }
        public static void SelectFigure()
        {
            Console.WriteLine("Выберете фигуру ");
        }
        public static void ErrorOutput()
        {
            Console.WriteLine("Ошибка! Координаты введены неверно");
        }
        public static void OutputMoveResults(bool correct)
        {
            if (correct)
            {
                Console.WriteLine("Ход коня верный!");
            }
            else 
            {
                Console.WriteLine("Ход коня неверный!");
            }
        }
    }
}
