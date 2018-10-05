using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._92
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] v;
            double k;
            

            Console.WriteLine("Введите n ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n >= 4)
            {
                v = new double[n];
                v[0] = v[1] = 0;
                v[2] = 1.5;

                for(int i = 3; i < n; i++)
                {
                    k = (double)i + 1;
                    v[i] = ((k + 1) / (k * k + 1)) * v[i - 1] - v[i - 2] * v[i - 3];
                }

                Console.WriteLine("Vn = {0}", v[n-1]);
                Console.ReadKey();
            }



        }
    }
}
