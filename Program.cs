using System;
using System.Globalization;

namespace Programowanie_zadania_na_zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 2;
            int[,] tab = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j=0; j<10; j++)
                {
                    tab[i, j] = liczba;
                    liczba += 2; 
                }
            }
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
