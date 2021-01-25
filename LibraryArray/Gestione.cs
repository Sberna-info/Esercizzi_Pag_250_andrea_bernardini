using System;

namespace LibraryArray
{
    public class Gestione
    {
        public static void LeggiArray(int[] array)
        {
            int c = 0;
            for (; c < array.Length; c++)
            {
                Console.Write($"Inserisci il {c + 1}° numero: ");
                array[c] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Stampa(int[] array, int lunghezza)
        {
            for (int c = 0; c < lunghezza; c++)
            {
                Console.Write($"{array[c]} ");
            }
            Console.WriteLine();
        }
    }
}
