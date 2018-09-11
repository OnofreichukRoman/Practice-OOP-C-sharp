using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._30
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, r, r2;

            Console.WriteLine("Введите х ");
            x = Convert.ToDouble(Console.ReadLine());

            r = 1 + x * (-2 + x * (3 - 4 * x));
            r2 = 1 + x * (2 + x * (3 + 4 * x));

            Console.WriteLine(r);
            Console.WriteLine(r);
            Console.ReadKey();

            //Схема Горнера
        }
    }
}
