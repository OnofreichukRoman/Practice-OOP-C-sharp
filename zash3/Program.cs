using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zash3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] key = {{'Ж', 'Щ', 'Н', 'Ю', 'Р'},
                        {'И', 'Т', 'Ь', 'Ц', 'Б'},
                        {'Я', 'М', 'Е', '.', 'С'},
                        {'В', 'Ы', 'П', 'Ч', '_'},
                        {':', 'Д', 'У', 'О', 'К'},
                        {'З', 'Э', 'Ф', 'Г', 'Ш'},
                        {'Х', 'А', ',', 'Л', 'Ъ'}};

            char[,] key2 = {{'И', 'Ч', 'Г', 'Я', 'Т'},
                        {',', 'Ж', 'Ь', 'М', 'О'},
                        {'З', 'Ю', 'Р', 'В', 'Щ'},
                        {'Ц', ':', 'П', 'Е', 'Л'},
                        {'Ъ', 'А', 'Н', '.', 'Х'},
                        {'Э', 'К', 'С', 'Ш', 'Д'},
                        {'Б', 'Ф', 'У', 'Ы', '_'}};

            char[,] key4 = {{'Ж', 'Щ', 'Н', 'Ю', 'Р'},
                        {'И', 'Т', 'Ь', 'Ц', 'Б'},
                        {'Я', 'М', 'Е', '.', 'С'},
                        {'В', 'Ы', 'П', 'Ч', '_'},
                        {':', 'Д', 'У', 'О', 'К'},
                        {'З', 'Э', 'Ф', 'Г', 'Ш'},
                        {'Х', 'А', ',', 'Л', 'Ъ'}};

            char[,] key3 = {{'И', 'Ч', 'Г', 'Я', 'Т'},
                        {',', 'Ж', 'Ь', 'М', 'О'},
                        {'З', 'Ю', 'Р', 'В', 'Щ'},
                        {'Ц', ':', 'П', 'Е', 'Л'},
                        {'Ъ', 'А', 'Н', '.', 'Х'},
                        {'Э', 'К', 'С', 'Ш', 'Д'},
                        {'Б', 'Ф', 'У', 'Ы', '_'}};


            string input;


            Console.WriteLine("Введите сообщение для зашифровки: ");
            input = Console.ReadLine();

            input = input.Replace(" ", "_");
            input = input.ToUpper();

            if (input.Length % 2 != 0)
            {
                input = input + "_";
                Console.WriteLine(input);
            }

            char[] mes = input.ToCharArray();
            int[] oneWord = new int[2];
            int[] twoWord = new int[2];

            for (int k = 0; k < mes.Length - 1; k += 2)
            {


                for (int m = 0; m < 7; m++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int tmp1, tmp2, tmp3, tmp4;

                        tmp1 = mes[k];
                        tmp2 = key[m, i];
                        tmp3 = mes[k + 1];
                        tmp4 = key2[m, i];

                        if (tmp1 == tmp2)
                        {
                            oneWord[0] = m;
                            oneWord[1] = i;
                        }

                        if (tmp3 == tmp4)
                        {
                            twoWord[0] = m;
                            twoWord[1] = i;
                        }

                    }
                }

                if (oneWord[0] == twoWord[0])
                {
                 
                    int one = oneWord[0];
                    int two = oneWord[1];
                    mes[k] = key2[one, two];

                    mes[k + 1] = key[twoWord[0], twoWord[1]];
                
                }
                else if (oneWord[1] == twoWord[1])
                {
                 
                    mes[k] = key2[oneWord[0], oneWord[1]];
                    mes[k + 1] = key[twoWord[0], twoWord[1]];
                }
                else
                {
                    int raz = Math.Abs(oneWord[0] - twoWord[0]);
                    if (raz == 0)
                    {
                        raz = 1;
                    }

                    if (twoWord[0] < oneWord[0])
                    {
                        twoWord[0] = twoWord[0] + raz;
                        oneWord[0] = oneWord[0] - raz;
                    }
                    else
                    {
                        twoWord[0] = twoWord[0] - raz;
                        oneWord[0] = oneWord[0] + raz;
                    }
                    mes[k] = key2[twoWord[0], twoWord[1]];
                    mes[k + 1] = key[oneWord[0], oneWord[1]];
                }

                Console.Write(mes[k]);
                Console.Write(mes[k + 1]);
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.WriteLine("Введите сообщение для расшифровки: ");
            input = Console.ReadLine();

            input = input.Replace(" ", "");
            input = input.ToUpper();

            mes = input.ToCharArray();
            oneWord = new int[2];
            twoWord = new int[2];

            for (int k = 0; k < mes.Length - 1; k += 2)
            {


                for (int m = 0; m < 7; m++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int tmp1, tmp2, tmp3, tmp4;

                        tmp1 = mes[k];
                        tmp2 = key3[m, i];
                        tmp3 = mes[k + 1];
                        tmp4 = key4[m, i];

                        if (tmp1 == tmp2)
                        {
                            oneWord[0] = m;
                            oneWord[1] = i;
                        }

                        if (tmp3 == tmp4)
                        {
                            twoWord[0] = m;
                            twoWord[1] = i;
                        }

                    }
                }

                if (oneWord[0] == twoWord[0])
                {

                    int one = oneWord[0];
                    int two = oneWord[1];
                    mes[k] = key4[one, two];

                    mes[k + 1] = key3[twoWord[0], twoWord[1]];
                    
                }
                else if (oneWord[1] == twoWord[1])
                {

                    mes[k] = key4[oneWord[0], oneWord[1]];
                    mes[k + 1] = key3[twoWord[0], twoWord[1]];
                }
                else
                {
                    int raz = Math.Abs(oneWord[0] - twoWord[0]);
                    if (raz == 0)
                    {
                        raz = 1;
                    }

                    if (twoWord[0] < oneWord[0])
                    {
                        twoWord[0] = twoWord[0] + raz;
                        oneWord[0] = oneWord[0] - raz;
                    }
                    else
                    {
                        twoWord[0] = twoWord[0] - raz;
                        oneWord[0] = oneWord[0] + raz;
                    }
                    mes[k] = key4[twoWord[0], twoWord[1]];
                    mes[k + 1] = key3[oneWord[0], oneWord[1]];
                }

                Console.Write(mes[k]);
                Console.Write(mes[k + 1]);
               
            }
            Console.ReadKey();
        }
    }
}
