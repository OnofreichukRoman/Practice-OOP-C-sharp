using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._86
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num;
            num = 0;

            Console.WriteLine("Введите n ");
            n = Convert.ToInt32(Console.ReadLine());

            //a
            int nA = n;
            while (nA > 0)
            {
                nA = nA / 10;
                num++;
            }
            Console.WriteLine(num);

            //б
            int nB = n;
            num = 0;
            while (nB != 0)
            {
                
                num = num + (nB % 10);
                nB = nB / 10;
            }
            Console.WriteLine(num);
            //в

            int nC = n;
            while (nC > 9)
            {
                nC = nC / 10;
            }
            Console.WriteLine(nC);

            //г 
            int sum, nD, m, sign;
            m = 0;
            nD = n;
            sum = 0;
            while (n != 0)
            {
                m++;
                n = n / 10;
            }

            n = nD;

            if (m % 2 == 0)
                sign = -1;
            else
                sign = 1;

            while(n != 0)
            {
                sum = sum + sign * (n % 10);
                n = n / 10;
                sign = -1 * sign;
            }

            Console.WriteLine(sum);
        
            
            Console.ReadKey();
        }
    }
}
