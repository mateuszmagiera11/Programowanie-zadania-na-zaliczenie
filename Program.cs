using System.Numerics;
using System;

namespace Programowanie_zadania_na_zaliczenie
{
    class Program
    {
        public static BigInteger silnia(BigInteger n)
        {
            if (n < 2)
                return 1;
            else
                return n * silnia(n - 1);
        }
        static void Main(string[] args)
        {
            BigInteger i;
            Console.WriteLine("Pdaj liczbę z której chcesz obliczyć silnię: ");
            i = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Wynik to: " + silnia(i));
        }
    }
}
