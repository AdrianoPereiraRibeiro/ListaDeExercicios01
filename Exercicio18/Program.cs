﻿namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores diferentes:");
            string n1i = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();

            int n1ii = Convert.ToInt32(n1i);
            int n2i = Convert.ToInt32(n2);
            int n3i = Convert.ToInt32(n3);
            int[] numeros = { n1ii, n2i, n3i };
            Array.Sort(numeros); //Na parte do Array, pedi ajuda no copilot.
            Array.Reverse(numeros);
            Console.WriteLine("Números em ordem decrescente:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();













        }

    }
    }

