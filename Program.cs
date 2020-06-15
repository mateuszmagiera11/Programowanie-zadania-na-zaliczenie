using System;

namespace Programowanie_zadania_na_zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] fib = new double[100];
            fib[0] = 1;
            fib[1] = 1;

            for(int i = 2; i < 100; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Wyraz "+(i+1)+" to "+fib[i] ); 
            }
            Console.ReadLine();
        }
    }
}
