using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR1_2
{
    class Program
    {
        static void Main(String[] args)
        {
                double x, y;
                Console.WriteLine("Введите x");
                x = Convert.ToDouble(Console.ReadLine());

                if (x >= -7 && x <= 3)
                {
                    if (x >= -7 && x <= -6)
                    {
                        y = 2;
                    }
                    else if (x > -6 && x <= -2)
                    {
                        y = 0.25 * x + 0.5;
                    }
                    else if (x > -2 && x <= 0)
                    {
                        y = 2 - Math.Sqrt(4 - Math.Pow((x + 2), 2));
                    }
                    else if (x > 0 && x <= 2)
                    {
                        y = Math.Sqrt(4 - Math.Pow(x, 2));
                    }
                    else
                    {
                        y = -x + 2;
                    }
                    Console.WriteLine("y = " + y);
                }
                else
                {
                    Console.WriteLine("Ошибка. Функция неопределена");
                }
                Console.ReadLine();
        }
    }
}
