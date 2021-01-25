using System;
using LibraryArray;

namespace Es_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 30;
            Random r = new Random();
            int cont_pari = 0;
            int[] pari = new int[N];
            int cont_dispari = 0;
            int[] dispari = new int[N];
            for(int i = 0; i< N;i++)
            {
                int m = r.Next();
                if(m % 2 == 0)
                {
                    pari[cont_pari++] = m;
                }
                else
                {
                    dispari[cont_dispari++] = m;

                }
            }
            Console.Write("Pari: ");
            Gestione.Stampa(pari, cont_pari);
            Console.WriteLine();
            Console.Write("Dispari: ");
            Gestione.Stampa(dispari, cont_dispari);
        }
    }
}
