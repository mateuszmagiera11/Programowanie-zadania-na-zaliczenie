using System;

namespace Programowanie_zadania_na_zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nominaly = { 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
            double reszta;
            int i;
            Console.WriteLine("Podaj kwotę do wypłaty: ");
            if(!double.TryParse(Console.ReadLine(), out reszta))
            {
                Console.WriteLine("Podano nieprawidłową kwotę! ");
                Console.ReadKey();
                Environment.Exit(0);
            }
            i = 0;
            while (reszta > 0)
            {
                if (reszta >= nominaly[i])
                {
                    int liczbanominalow = (int)(reszta / nominaly[i]);
                    reszta = Math.Round(reszta - nominaly[i] * liczbanominalow, 2);
                    Console.WriteLine("Wypłacono: " + liczbanominalow + "x" + nominaly[i] + "PLN");
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
