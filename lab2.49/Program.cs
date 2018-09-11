using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._49
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, a, b, c, D, x1, x2;

            Console.WriteLine("Введите h ");
            h = Convert.ToDouble(Console.ReadLine());

            a = Math.Sqrt((Math.Abs(Math.Sin(8 * h) + 17)) / Math.Pow((1 - Math.Sin(4 * h) * Math.Cos(h * h + 18)),2));
            b = 1 - Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a) * h * h - Math.Sin(a) * h)));
            c = a * h * h * Math.Sin(b) * h + b * h * h * h * Math.Cos(a) * h;

            D = b * b - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D) / 2 * a);

                x2 = (-b - Math.Sqrt(D) / 2 * a);

                Console.WriteLine("x1 = {0} x2 = {1} ", x1, x2);
                Console.ReadKey();
            }
            else if(D == 0)
            {
                x1 = x2 = -(b / 2 * a);

                Console.WriteLine("x = {0}", x1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Корней нет");
                Console.ReadKey();
            }
        }
    }
}
