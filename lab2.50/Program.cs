using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._50
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, b1, b2, c1, c2, x, y;

            Console.WriteLine("Введите a1 ");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите a2 ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b1 ");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b2 ");
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c1 ");
            c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c2 ");
            c2 = Convert.ToDouble(Console.ReadLine());

            if (Math.Abs(a1 * b2 - a2 * b1) >= 0.0001)
            {
                x = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
                y = (c1 * a2 - c2 * a1) / (a1 * b2 - a2 * b1);

                Console.WriteLine("x = {0}", x);
                Console.WriteLine("y = {0}", y);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Условие не выполнено");
                Console.ReadKey();
            }

            //Система линейных уравнений. Методом Крамера
        }
    }
}
