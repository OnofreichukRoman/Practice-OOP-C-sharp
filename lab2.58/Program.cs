using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._58
{
    class Program
    {
        static void Main(string[] args)
        {
            double ya, yb, yc, yd, x;


            Console.WriteLine("Введите x ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x < 0)
                ya = -x;
            else if (x > 0)
                ya = -(x * x);
            else
                ya = 0;

            Console.WriteLine("y(a) = "+ya);

            if (x < -1)
                yb = 1 / (x * x);
            else if (x >= -1 && x < 2)
                yb = x * x;
            else
                yb = 4;

            Console.WriteLine("y(б) = " + yb);

            if (x >= -2 && x <= -1 || x >= 1 && x <= 2)
                yc = Math.Abs(x) - 1;
            else if (x >= -1 && x <= 0 || x >= 0 && x <= 1)
                yc = 1 - Math.Abs(x);
            else
                yc = Math.Abs(x);

            Console.WriteLine("y(в) = " + yc);

            if (x >= 0)
            {
                if (x <= 0)
                    yd = Math.Abs(x);
                else if (x > 0 && x < 2)
                {
                    if (x > 1)
                        yd = 1;
                    else
                        yd = x;
                }
                else 
                    yd = 2 * (0.5 - (x - 2));

                Console.WriteLine("y(г) = " + yd);
            }
        }
    }
}
