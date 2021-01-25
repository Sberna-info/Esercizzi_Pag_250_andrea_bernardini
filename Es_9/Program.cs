using System;
using LibraryArray;

namespace Es_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci N: ");
            int n = int.Parse(Console.ReadLine());
            int cont_vetA = 0;
            int[] vetA = new int[n];
            for(int c = 0; c < n;c++)
            {
                Console.Write("inserisci un numero: ");
                int numeri = int.Parse(Console.ReadLine());

                vetA[cont_vetA++] = numeri;
            }


        }
    }
}
