using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero, i;
            int[] vet;

            Console.WriteLine("Insira o numero abaixo: ");

            numero = int.Parse(Console.ReadLine());
            vet = new int[numero];


            string[] vet2 = Console.ReadLine().Split(' ');

            for (i = 0; i < numero; i++)
            {
                vet[i] = int.Parse(vet2[i]);
            }

            for (i = 0; i < numero; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}