using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, a, b;

            Console.WriteLine("Введите х");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите z");
            z = Convert.ToDouble(Console.ReadLine());

            a = y + x / (Math.Pow(y, 2) + Math.Abs(Math.Pow(x, 2) / (y + Math.Pow(x, 3) / 3)));
            b = 1 + Math.Pow(Math.Tan(z / 2), 2);

            Console.WriteLine("Результат a = {0}", a);
            Console.WriteLine("Результат b = {0}", b);
            Console.ReadKey();

        }
    }
}
