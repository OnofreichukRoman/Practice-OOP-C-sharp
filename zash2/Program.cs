using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zash2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] key = {{'Б', 'А', 'Н', 'Д', 'Е', 'Р', 'О', 'Л', ':'},
                        {'Ь', 'В', 'Г', 'Ж', 'З', 'И', 'Й', 'К', '.'},
                        {'М', 'П', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', ','},
                        {'Ч', 'Ш', 'Щ', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', '-'}};

            string input;

            
                Console.WriteLine("Введите сообщение для зашифровки: ");
                input = Console.ReadLine();
                input = input.Replace(" ", "");
                input = input.ToUpper();

                if (input.Length % 2 != 0)
                {
                    input = input + ".";
                    Console.WriteLine(input);
                }
               
                    
           

            char[] mes = input.ToCharArray();
            int[] oneWord = new int[2];
            int[] twoWord = new int[2];

            for (int k = 0; k < mes.Length-1; k+=2)
            {
    

                for (int m = 0; m < 4; m++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        int tmp1, tmp2, tmp3;

                        tmp1 = mes[k];
                        tmp2 = key[m, i];
                        tmp3 = mes[k + 1];

                        if(tmp1 == tmp2)
                        {
                            oneWord[0] = m;
                            oneWord[1] = i;
                        }

                        if (tmp3 == tmp2)
                        {
                            twoWord[0] = m;
                            twoWord[1] = i;
                        }

                        }
                    }

                    if(oneWord[0] == twoWord[0])
                    {
                        if (oneWord[1] == 8)
                            oneWord[1] = -1;
                        if (twoWord[1] == 8)
                            twoWord[1] = -1;

                        int one = oneWord[0];
                        int two = oneWord[1] + 1;
                        mes[k] = key[one,two];

                        mes[k + 1] = key[twoWord[0], twoWord[1] + 1];
                    }
                    else if(oneWord[1] == twoWord[1])
                    {
                        if (oneWord[0] == 3)
                            oneWord[0] = -1;
                        if (twoWord[0] == 3)
                            twoWord[0] = -1;

                        mes[k] = key[oneWord[0] + 1, oneWord[1]];
                        mes[k + 1] = key[twoWord[0] + 1, twoWord[1]];
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
                        mes[k] = key[twoWord[0], twoWord[1]];
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


                for (int m = 0; m < 4; m++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        int tmp1, tmp2, tmp3;

                        tmp1 = mes[k];
                        tmp2 = key[m, i];
                        tmp3 = mes[k + 1];

                        if (tmp1 == tmp2)
                        {
                            oneWord[0] = m;
                            oneWord[1] = i;
                        }

                        if (tmp3 == tmp2)
                        {
                            twoWord[0] = m;
                            twoWord[1] = i;
                        }

                    }
                }

                if (oneWord[0] == twoWord[0])
                {
                    if (oneWord[1] == 0)
                        oneWord[1] = 9;
                    if (twoWord[1] == 0)
                        twoWord[1] = 9;

                    int one = oneWord[0];
                    int two = oneWord[1] - 1;
                    mes[k] = key[one, two];

                    mes[k + 1] = key[twoWord[0], twoWord[1] - 1];
                }
                else if (oneWord[1] == twoWord[1])
                {
                    if (oneWord[0] == 3)
                        oneWord[0] = -1;
                    if (twoWord[0] == 3)
                        twoWord[0] = -1;

                    mes[k] = key[oneWord[0] + 1, oneWord[1]];
                    mes[k + 1] = key[twoWord[0] + 1, twoWord[1]];
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
                    mes[k] = key[twoWord[0], twoWord[1]];
                    mes[k + 1] = key[oneWord[0], oneWord[1]];
                }

                Console.Write(mes[k]);
                Console.Write(mes[k + 1]);
                
            }

            Console.ReadKey();
            }

        }
    }


