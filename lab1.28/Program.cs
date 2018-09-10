using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._28
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, r;

            Console.WriteLine("Введите х ");
            x = Convert.ToDouble(Console.ReadLine());

            r = (((2 * x - 3) * x + 4)*x - 5)*x + 6;
            Console.WriteLine(r);
            Console.ReadKey();
            
            //Схема Горнера
            }
          
        }
    }

