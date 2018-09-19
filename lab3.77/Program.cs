using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._77
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, de;
            double b, sum, c, s2, es, es1, es2, es3, s3;

            a = 2;
            b = 2;
            sum = 0;
            c = 0;
            s2 = Math.Sqrt(2);
            s3 = 0;
            es = Math.Cos(1) / Math.Sin(1);
            es1 = 0;
            es2 = 0;
            int result = 1;

            Console.WriteLine("Введите n ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                //a
                for (int i = 1; i < n; i++)
                    a = a * 2;

                Console.WriteLine("а "+a);

                //б
                for (int k = 1; k <= n; k++)
                    result = result * k;

                Console.WriteLine("б "+result);

                //в
                Console.Write("в ");
                for (int k1 = 1; k1 <= n; k1++)
                {
                    b = (1 + (1 / (double)(k1 * k1)));
                    Console.Write(b + " ");
                }

                Console.WriteLine();
                //г
                for(int k2 = 1; k2 <= n; k2++)
                {
                    c = c + Math.Sin((double)k2);
                    sum = sum + 1 / c;
                }
                Console.WriteLine("г "+sum);


                //д
                for (int k2 = 1; k2 < n; k2++)
                {
                    s2 = Math.Sqrt(2 + s2); 
                }
                Console.WriteLine("д "+s2);

                //е
                for (int k2 = 1; k2 < n; k2++)
                {
                    for (int f2 = 1; f2 <= n; f2++)
                    {
                        es1 = es1 + Math.Cos(n);
                        es2 = es2 + Math.Sin(n);
                    }
                    es3 = es1 / es2;
                    es = es * es3;
                }
                Console.WriteLine("е "+es);

                //ж
                de = n;
                for (int k2 = 0; k2 < n; k2++)
                {
                    s3 = Math.Sqrt(3*(de--) + s3);
                }
                Console.WriteLine("ж "+s3);
            }
            else
                Console.WriteLine("n<1");
            Console.ReadKey();
        }
    }
}
