using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._88
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

                Console.WriteLine("Введите n ");
                n = Convert.ToInt32(Console.ReadLine());

                //a
                int nA;
                nA = n * n;
                string s = "No";

                while (nA != 0)
                {
                    if (nA % 10 == 3)
                    {
                        s = "Yes";
                        break;
                    }
                    else
                        nA = nA / 10;
                }

                Console.WriteLine("a " + s);
            
            //б
            double res = 0;
            int nB = n;

            while (nB != 0)
            {
                res = res * 10 + (nB % 10);
                nB = nB / 10;
            }
            Console.WriteLine("б " + res);

            //в
            int nC = n;

            int i, last, first, p;
            res = 0;
            i = 1;
            p = 0;

         
            while (nC / i > 10)
            {
                nC = nC * 10;
                i = i * 10;
                //i = i / 10;
                first = nC / i/10;
                nC = nC / 10;
                last = (nC % 10) * i;
                p = ((nC/10) % (i/10)) % (i/10) * 10;
                res = last + p + first; 

            }
            Console.WriteLine("в " + res);

            //г
            int nD = n;
            int i2 = 10;
            int resul = 0;

            while(nD != 0)
            { 
                nD = nD / 10;
                i2 = i2 * 10;
            }

            resul = i2 + n * 10 + 1;
            Console.WriteLine("г " + resul);

            Console.ReadKey();
        }
    }
}
