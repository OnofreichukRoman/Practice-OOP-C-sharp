using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._31
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, a1, a2, a22, a3, a33, a4, a5, a6, a66, a7, a77, a8, a88, a888, a9, a99, a999, a10, a1010, a101010, a10101010, a11;

            Console.WriteLine("Введите a ");
            a = Convert.ToDouble(Console.ReadLine());
            //4
            a1 = a * a;
            a1 = a1 * a1;
            Console.WriteLine(a1);
            //6
            a22 = a * a;
            a2 = a22 * a22;
            a2 = a2 * a22;
            Console.WriteLine(a2);
            //7
            a33 = a * a;
            a3 = a33 * a33;
            a3 = a3 * a33;
            a3 = a3 * a;
            Console.WriteLine(a3);
            //8
            a4 = a * a;
            a4 = a4 * a4;
            a4 = a4 * a4;
            Console.WriteLine(a4);
            //9
            a5 = a * a;
            a5 = a5 * a5;
            a5 = a5 * a5;
            a5 = a5 * a;
            Console.WriteLine(a5);
            //10
            a66 = a * a;
            a6 = a66 * a66;
            a6 = a6 * a6;
            a6 = a6 * a66;
            Console.WriteLine(a6);
            //13
            a7 = a * a;
            a77 = a7 * a7;
            a7 = a77 * a77;
            a7 = a7 * a77;
            a7 = a7 * a;
            Console.WriteLine(a7);
            //15
            a8 = a * a;
            a88 = a8 * a;
            a888 = a88 * a88;
            a888 = a888 * a888;
            a888 = a888 * a88;
            Console.WriteLine(a888);
            //21
            a9 = a * a;
            a99 = a9 * a;
            a999 = a99 * a99;
            a999 = a999 * a999;
            a999 = a999 * a99;
            a999 = a999 * a99;
            Console.WriteLine(a999);
            //28
            a10 = a * a;
            a1010 = a10 * a10;
            a101010 = a1010 * a1010;
            a10101010 = a101010 * a101010;
            a10101010 = a10101010 * a101010;
            a10101010 = a10101010 * a1010;
            Console.WriteLine(a10101010);
            //64
            a11 = a * a;
            a11 = a11 * a11;
            a11 = a11 * a11;
            a11 = a11 * a11;
            a11 = a11 * a11;
            a11 = a11 * a11;
            Console.WriteLine(a11);

            Console.ReadKey();
        }
    }
}
