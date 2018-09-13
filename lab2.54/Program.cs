using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._54
{
    class Program
    {
        static void Main(string[] args)
        {
            //Расчет принадлежности начала координат треугольнику
            double x1, x2, x3, y1, y2, y3, x0, y0, a, b, c, d, e, f, s0, s1, s2, s3,sSum;
            float s;
            x0 = 0;
            y0 = 0;

            Console.WriteLine("Введите x1 (-3)");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2 (0)");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x3 (3)");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1 (-2)");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2 (2)");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y3 (-2)");
            y3 = Convert.ToDouble(Console.ReadLine());

            a = Length(x1, x2, y1, y2);
            b = Length(x2, x3, y2, y3);
            c = Length(x3, x1, y3, y1);

            Console.WriteLine("a = {0} b = {1} c= {2}",a,b,c);
            Console.ReadKey();
            if(IsTriangle(a, b, c))
            {
                d = Length(x1, x0, y1, y0);
                e = Length(x3, x0, y3, y0);
                f = Length(x2, x0, y2, y0);
                s0 = Square(a, b, c);

                if (IsTriangle(a, d, f) && IsTriangle(e, f, b) && IsTriangle(e, c, d))
                {
                    s1 = Square(a, d, f);
                    s2 = Square(e, f, b);
                    s3 = Square(e, c, d);
                    sSum = s1 + s2 + s3;

                    Console.WriteLine("d = {0} e = {1} f = {2} s = {3} s1 = {4}, s2 = {5} s3 = {6}", d, e, f, s0, s1, s2, s3);
                    s = (float)sSum;

                    if (s0 == s)
                        Console.WriteLine("Начало координат принадлежит треугольнику");
                    else
                        Console.WriteLine("Начало координат не принадлежит треугольнику");
                    Console.ReadKey();

                }
                else if ((IsTriangle(a, d, f) && IsTriangle(e, f, b)) || (IsTriangle(e, f, b) && IsTriangle(e, c, d)) || (IsTriangle(a, d, f) && IsTriangle(e, c, d)))
                {
                    if(IsTriangle(a, d, f) && IsTriangle(e, f, b))
                    {
                        s1 = Square(a, d, f);
                        s2 = Square(e, f, b);
                        sSum = s1 + s2;
                        s = (float)sSum;

                        if(s0 == s)
                            Console.WriteLine("Начало координат принадлежит треугольнику");
                        else
                            Console.WriteLine("Начало координат не принадлежит треугольнику");

                    }
                    else if(IsTriangle(e, f, b) && IsTriangle(e, c, d))
                    {
                        s2 = Square(e, f, b);
                        s3 = Square(e, c, d);
                        sSum = s2 + s3;
                        s = (float)sSum;

                        if (s0 == s)
                            Console.WriteLine("Начало координат принадлежит треугольнику");
                        else
                            Console.WriteLine("Начало координат не принадлежит треугольнику");
                    }
                    else if(IsTriangle(a, d, f) && IsTriangle(e, c, d))
                    {
                        s1 = Square(a, d, f);
                        s3 = Square(e, c, d);
                        sSum = s1 + s3;
                        s = (float)sSum;

                        if (s0 == s)
                            Console.WriteLine("Начало координат принадлежит треугольнику");
                        else
                            Console.WriteLine("Начало координат не принадлежит треугольнику");
                    }
                }
                else
                    Console.WriteLine("Начало координат принадлежит треугольнику, точка является одной из вершин");
            }

        }

        static double Length(double x1, double x2, double y1, double y2)
        {
            double length = 0;

            length = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2), 0.5);

            return length;
        }

        static bool IsTriangle(double a, double b, double c)
        {
            if ((a < b + c) && (b < a + c) && (c < a + b))
                return true;
            else
                return false;
        }

        static double Square(double a, double b, double c)
        {
            double p, s;

            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
