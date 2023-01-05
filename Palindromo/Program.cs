using System;
using System.Collections.Generic;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;

            Console.WriteLine("Digite a frase ou palavra a ser verificada:");

            palavra = Console.ReadLine();

            int x = palavra.Length - 1;

            while (x != -1)
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == palavra[x])
                    {
                        if (x == 0)
                        {
                            Console.WriteLine("E palindromo!");
                            Console.WriteLine();
                        }
                        x--;
                    }
                    else
                    {
                        Console.WriteLine("Nao e palindromo!");
                        i = palavra.Length;
                        x = -1;

                        Console.ReadLine();
                    }
                }
            }
        }
    }
}