using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, z1, z2;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 2 || a == -2 || a == 0)
            {
                Console.WriteLine("Ошибка (нельзя делить на ноль)");
            }
            else
            {
                z1 = Math.Pow((((1 + a + Math.Pow(a, 2)) / (2 * a + Math.Pow(a, 2))) + 2 - ((1 - a + Math.Pow(a, 2)) / (2 * a - Math.Pow(a, 2)))), -1) * (5 - 2 * Math.Pow(a, 2));
                z2 = (4 - Math.Pow(a, 2)) / 2;

                Console.WriteLine("z1 равно " + z1);
                Console.WriteLine("z2 равно " + z2);
            }
            Console.ReadLine();
        }
    }
}
