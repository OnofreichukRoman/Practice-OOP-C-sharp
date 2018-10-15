using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zash4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("n ");
            int n = Convert.ToInt32(Console.ReadLine());


            int v3, u3;
            v3 = a;
            u3 = n;

            int u1 = 0, v2 = 0, u2 = 1, v1 = 1, q;
            Vector u = new Vector(u1, u2, u3);
            Vector v = new Vector(v1, v2, v3);
            Vector t;

            if (Nod(a, n) == 1)
            {

                while (u.c != 1)
                {
                    q = u.c / v.c;
                    t = u.minus(v.scalMore(q));
                    u = v;
                    v = t;
                }

                if (u.a < 0)
                    u.a = u.a + n;

                Console.WriteLine("{0}^-1(mod{1}) = {2}", a, n, u.a);
            }
            else
                Console.WriteLine("Sorry :(");

            Console.ReadKey();
        }

        static int Nod(int a, int b)
        {
            //    if (a == 0)
            //    {
            //        x = 1;
            //        y = 0;
            //        return b;
            //    }
            //    else if (b == 0)
            //    {
            //        x = 0;
            //        y = 1;
            //        return a;
            //    }



            while (b != 0)

            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }

            return a;
        }


    }
    class Vector
    {
        public int a, b, c;

        public Vector()
        {
            this.a = this.b = this.c = 0;
        }

        public Vector(int a, int b, int c)
        {

            this.a = a;
            this.b = b;
            this.c = c;

        }

        public Vector scalMore(int scal)
        {
            Vector rez = new Vector();
            rez.a = a * scal;
            rez.b = b * scal;
            rez.c = c * scal;

            return rez;


        }

        public Vector minus(Vector t)
        {
            Vector rez = new Vector();
            rez.a = a - t.a;
            rez.b = b - t.b;
            rez.c = c - t.c;
            return rez;
        }

    }

}

