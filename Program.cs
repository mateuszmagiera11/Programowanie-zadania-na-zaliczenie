using System.Numerics;
using System;

namespace Programowanie_zadania_na_zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n, wynik = 1;
            Console.WriteLine("Podaj liczbę dla jakiej chcesz obliczyć silnię: ");
            n = BigInteger.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                wynik *= i;
            }
            Console.WriteLine("Wynik to: " + wynik);
        }
    }
}
