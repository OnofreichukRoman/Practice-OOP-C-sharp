using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zash1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово: ");
            string slovo = Console.ReadLine();
            slovo = slovo.ToLower();

            char[,] shifr = new char[slovo.Length, slovo.Length];
            Console.WriteLine("Введите текст: ");

            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            text = text.ToLower();
            Console.WriteLine();

            int strok = text.Length / slovo.Length;
            if((slovo.Length*strok) != text.Length)
            {
                strok++;
            }
            int k = 0;

            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < slovo.Length; j++)
                {
                    if (k >= text.Length)
                        shifr[i, j] = ' ';
                    else
                    {
                        shifr[i, j] = text[k];
                        k++;
                    }
                }
            }

            bool isSorted = false;
            char[,] tmp = new char[strok, slovo.Length];
            char[] slovoTmp = new char[slovo.Length];

            for (int j = 0; j < slovo.Length; j++)
            {
                slovoTmp[j] = slovo[j];
            }

            char Tmp;

            while (!isSorted)
            {
                isSorted = true;

                for (int j = 0; j < slovo.Length-1; j++)
                {
                    if ((int)slovoTmp[j] > (int)slovoTmp[j + 1])
                    {
                        Tmp = slovoTmp[j + 1];
                        slovoTmp[j + 1] = slovoTmp[j];
                        slovoTmp[j] = Tmp;

                        for (int m = 0; m < strok; m++)
                        {
                            tmp[m, j] = shifr[m, j];
                            shifr[m, j] = shifr[m, j + 1];
                            shifr[m, j + 1] = tmp[m, j];
                        }
                        isSorted = false;
                    }
                }
            }

            for (int j = 0; j < slovo.Length; j++)
            {
                Console.Write(slovoTmp[j]);
            }

            Console.WriteLine();

            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < slovo.Length; j++)
                {
                    Console.Write(shifr[i,j]+" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < slovo.Length; i++)
            {
                for (int j = 0; j < strok; j++)
                {
                    Console.Write(shifr[j, i]);
                }
            }
            Console.WriteLine("\n");
           

            Console.WriteLine("Введите слово ключ: ");
            slovo = Console.ReadLine();
            slovo = slovo.ToLower();

            Console.WriteLine("Введите зашифрованный ключ");
            slovoTmp = Console.ReadLine().ToCharArray();

            shifr = new char[slovo.Length, slovo.Length];
            Console.WriteLine("Введите зашифрованный текст: ");

            text = Console.ReadLine();
            text = text.Replace(" ", "");
            text = text.ToLower();

            Console.WriteLine();

            strok = text.Length / slovo.Length;
            if ((slovo.Length * strok) != text.Length)
            {
                strok++;
            }
            k = 0;

            for (int i = 0; i < slovo.Length; i++)
            {
                for (int j = 0; j < strok; j++)
                {
                    if (k >= text.Length)
                        shifr[j, i] = ' ';
                    else
                    {
                        shifr[j, i] = text[k];
                        k++;
                    }
                }
            }
         
            tmp = new char[strok, slovo.Length];

            for(int f = 0; f <slovo.Length;f++)
            {
               
                for (int j = 0; j < slovo.Length; j++)
                {
                    if ((int)slovo[f] == (int)slovoTmp[j])
                    {
                        Tmp = slovoTmp[j];
                        slovoTmp[j] = slovoTmp[f];
                        slovoTmp[f] = Tmp;

                        for (int m = 0; m < strok; m++)
                        {
                            tmp[m, j] = shifr[m, j];
                            shifr[m, j] = shifr[m, f];
                            shifr[m, f] = tmp[m, j];
                        }       
                    }
                }
            }

            for (int j = 0; j < slovo.Length; j++)
            {
                Console.Write(slovoTmp[j]);
            }

            Console.WriteLine();

            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < slovo.Length; j++)
                {
                    Console.Write(shifr[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < slovo.Length; j++)
                {
                    Console.Write(shifr[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
