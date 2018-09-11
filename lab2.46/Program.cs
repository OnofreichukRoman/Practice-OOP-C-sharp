using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._46
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Введите x ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y ");
            y = Convert.ToDouble(Console.ReadLine());

            if (x < 0 && y < 0)
            {
                x = Math.Abs(x);
                y = Math.Abs(y);

            }
            else if (x < 0 || y < 0)
            {
                x = x * 0.5;
                y = y * 0.5;

            }
            else if(x >= 0 && y >= 0 && (x < 0.5 && y < 0.5) || (x > 2 && y > 2))
            {
                x = x / 10;
                y = y / 10;
            }

            Console.WriteLine("Теперь х = {0} у = {1}", x, y);
            Console.ReadKey();
        }
    }
}
