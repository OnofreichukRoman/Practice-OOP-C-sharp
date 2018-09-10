using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, d, x1, x2, D, tmp, r;
            x1 = 0;
            x2 = 0;

            Console.WriteLine("Введите c ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите d ");
            d = Convert.ToDouble(Console.ReadLine());

            D = 9 - 4 * -Math.Abs(c * d);

            if(D >= 0)
            {
                if (D > 0)
                {
                    x1 = (-9 + Math.Sqrt(D)) / 2;
                    x2 = (-9 - Math.Sqrt(D)) / 2;

                    if (x2 > x1)
                    {
                        tmp = x1;
                        x1 = x2;
                        x2 = tmp;
                    }
                }
                else if (D == 0)
                    x1 = x2 = -(9 / 2);
            }

            r = Math.Abs((Math.Pow(Math.Sin(Math.Abs(c * Math.Pow(x1, 3) + d * Math.Pow(x2, 2) - c * d)), 3))/
                Math.Sqrt((Math.Pow(c * Math.Pow(x1,3) + d * Math.Pow(x2,2) - x1,2) + 3.14))) +
                Math.Tan(c * Math.Pow(x1,3) + d* Math.Pow(x2,2) - x1);

            Console.WriteLine("Результат вычислений r = {0}", r);
            Console.ReadKey();
        }
    }
}
