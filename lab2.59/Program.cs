using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._59
{
    class Program
    {
        static void Main(string[] args)
        {
            double l, x, y;
            //int num;

            Console.WriteLine("Введите x ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y ");
            y = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Введите num ");
            //num = Convert.ToInt32(Console.ReadLine());

            l = (0 - x) * (0 - x) + (0 - y) * (0 - y);

            if (l >= 0 && l <= 1)
                Console.WriteLine("Точка принадлежит плоскости а");
            else
                Console.WriteLine("Точка не принадлежит плоскости а");

            if (l >= 0.5 && l <= 1)
                Console.WriteLine("Точка принадлежит плоскости б");
            else
                Console.WriteLine("Точка не принадлежит плоскости б");

            if (x > 1 || x < -1 || y > 1 || y < -1)
                Console.WriteLine("Точка не принадлежит плоскости в");
            else
                Console.WriteLine("Точка принадлежит плоскости в");

            //Не работает
            //if (InPolygon(x, y, num))
            //    Console.WriteLine("Точка принадлежит плоскости");
            //else
            //    Console.WriteLine("Точка не принадлежит");
            //Console.ReadKey

            if(Triangle(x, y, 0, 0, 0.5, 0, 0, 1) || Triangle(x, y, 0, 0, 0, 1, 0.5, 0) || Triangle(x, y, 0, 0, 0.5, 0, 0, -1) ||
                Triangle(x, y, 0, 0, 0, -1, -0.5, 0))
                Console.WriteLine("Точка принадлежит плоскости д");
            else
                Console.WriteLine("Точка не принадлежит плоскости д");

            Console.ReadKey();
        }

        static bool InPolygon(double x, double y, int num)
        {
            //алгоритм пересечания лучем ребер многогранника, четное вне, нечетное внутри, не работает
            double[] pX = new double[num];
            double[] pY = new double[num];

            int Pnum = pX.Length;
            int k = Pnum - 1;

            for (int g = 0; g < Pnum; g++)
            {
                Console.WriteLine("x" + (g + 1));
                pX[g] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("y" + (g + 1));
                pY[g] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < Pnum; i++)
            {
                if ((((pY[i] <= y) && (y < pY[k])) || ((pY[k] <= y) && (y < pY[i]))) && (x > (pX[k] - pX[i]) * (y - pY[i]) / (pY[k] - pY[i]) + pX[i]))
                {
                    return true;
                }
                k = i;
            }
            return false;
        }

        static bool Triangle(double x0, double y0, double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a, b, c, d, e, f, s0, s1, s2, s3, sSum;
            float s;

            a = Length(x1, x2, y1, y2);
            b = Length(x2, x3, y2, y3);
            c = Length(x3, x1, y3, y1);
            if (IsTriangle(a, b, c))
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

                    s = (float)sSum;

                    if (s0 == s)
                        return true;
                    else
                        return false;
                }
                else if ((IsTriangle(a, d, f) && IsTriangle(e, f, b)) || (IsTriangle(e, f, b) && IsTriangle(e, c, d)) || (IsTriangle(a, d, f) && IsTriangle(e, c, d)))
                {
                    if (IsTriangle(a, d, f) && IsTriangle(e, f, b))
                    {
                        s1 = Square(a, d, f);
                        s2 = Square(e, f, b);
                        sSum = s1 + s2;
                        s = (float)sSum;

                        if (s0 == s)
                            return true;
                        else
                            return false;

                    }
                    else if (IsTriangle(e, f, b) && IsTriangle(e, c, d))
                    {
                        s2 = Square(e, f, b);
                        s3 = Square(e, c, d);
                        sSum = s2 + s3;
                        s = (float)sSum;

                        if (s0 == s)
                            return true;
                        else
                            return false;
                    }
                    else if (IsTriangle(a, d, f) && IsTriangle(e, c, d))
                    {
                        s1 = Square(a, d, f);
                        s3 = Square(e, c, d);
                        sSum = s1 + s3;
                        s = (float)sSum;

                        if (s0 == s)
                            return true;
                        else
                            return false;
                    }
                }
                else
                    return false;
            }
            return false;
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
