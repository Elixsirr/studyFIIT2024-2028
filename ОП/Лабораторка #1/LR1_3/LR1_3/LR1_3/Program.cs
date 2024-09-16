using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR1_3
{
    class Program
    {
        static void Main(String[] args)
        {
            double x, y;
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());

            if (y >= 0)
            {
                if (y <= x && y >= Math.Pow((x - 2), 2) - 3)
                {
                    Console.WriteLine("Точка попала в мишень");
                }
                else
                {
                    Console.WriteLine("Точка НЕ попала в мишень");
                }
            }
            else
            {
                if (y <= -x && y >= Math.Pow((x - 2), 2) - 3)
                {
                    Console.WriteLine("Точка попала в мишень");
                }
                else
                {
                    Console.WriteLine("Точка НЕ попала в мишень");
                }
            }
            Console.ReadLine();
        }
    }
}