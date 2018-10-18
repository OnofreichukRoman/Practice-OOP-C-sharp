using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zash5
{
    class Program
    {
        static void Main(string[] args)
        {
            int g, p, x;
            Console.WriteLine("m Текст");
            string m = Console.ReadLine();
            Console.WriteLine("p модуль");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("g<p любое большое число");
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x<p любое целое");
            x = Convert.ToInt32(Console.ReadLine());


            int y = power(g, x, p);
            Console.WriteLine("Открытый: y = {0} g = {1} p = {2}",y,g,p);
            Console.WriteLine("Закрытый ключ: x = {0}",x);
            string text = "";


            if (m.Length > 0)
            {
                char[] temp = m.ToCharArray();

                for (int i = 0; i <= m.Length - 1; i++)
                {
                    int m2 = (int)temp[i];
                    if (m2 > 0)
                    {
                        int k = Rand() % (p - 2) + 1; // 1 < k < (p-1)
                        int a = power(g, k, p);
                        int b = mul(power(y, k, p), m2, p);
                        text = text + a + " " + b + " ";

                    }
                }
            }
            Console.WriteLine(text);

            Console.WriteLine("Шифрованный текст");
            text = Console.ReadLine();
            Console.WriteLine("p модуль");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x закрытый ключ");
            x = Convert.ToInt32(Console.ReadLine());

            string textDecrypt = "";
            if (text.Length > 0)
            {

                string[] strA = text.Split(' ');

                if (strA.Length > 0)
                {
                    for (int i = 0; i < strA.Length - 1; i += 2)
                    {
                        char[] a = new char[strA[i].Length];
                        char[] b = new char[strA[i + 1].Length];
                        int ai = 0;
                        int bi = 0;
                        a = strA[i].ToCharArray();
                        b = strA[i + 1].ToCharArray();
                        for (int j = 0; (j < a.Length); j++)
                        {
                            ai = ai * 10 + (int)(a[j] - 48);
                        }
                        for (int j = 0; (j < b.Length); j++)
                        {
                            bi = bi * 10 + (int)(b[j] - 48);
                        }
                        if ((ai != 0) && (bi != 0))
                        {
                            int deM = mul(bi, power(ai, p - 1 - x, p), p);// m=b*(a^x)^(-1)mod p =b*a^(p-1-x)mod p

                            deM = deM + 757;// +757 кодировка русского языка
                            
                            char m1 = (char)(deM);

                            textDecrypt = textDecrypt + m1;

                        }
                    }
                }

            }

            Console.WriteLine(textDecrypt);

            Console.ReadKey();
        }

        static private int Rand()
        {
            Random random = new Random();
            return random.Next();
        }

        static int power(int a, int b, int n) // a^b mod n
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }
        static int mul(int a, int b, int n) // a*b mod n 
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }
    }
}
