using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._60
{
    class Program
    {
        static void Main(string[] args)
        {
            double u, x, y;

            Console.WriteLine("Введите x ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y ");
            y = Convert.ToDouble(Console.ReadLine());

            if (((Math.Sqrt(x) + Math.Sqrt(y - 1)) < 1) && (y < (1 - Math.Sqrt(x))))
            {
                u = x - y;
                Console.WriteLine("Тoчка принадлежит D u=x-y");
            }
            else
            {
                u = x * y + 7;
                Console.WriteLine("Тoчка не принадлежит D u=xy+7");
            }

            Console.ReadKey();
        }
    }
}
