using System;

namespace Programowanie_zadania_na_zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybór, w1;
            double cena=0, cukier;
            Console.WriteLine("Witaj! Wybierz napój, który chcesz kupić: ");
            Console.WriteLine("1. Kawa 1,50 zł");
            Console.WriteLine("2. Herbata 1,00 zł");
            Console.WriteLine("3. Czekolada 2,00 zł");
            wybór =int.Parse (Console.ReadLine());
            
            switch (wybór)
            {
                case 1:
                    {
                        cena = 1.50;
                        Console.WriteLine("Wybrano kawę");
                        Console.WriteLine("Chcesz kupić cukier za 0,5 zł?");
                        Console.WriteLine("1. Tak");
                        Console.WriteLine("2. Nie");
                        w1 = int.Parse(Console.ReadLine());
                        if (w1 == 1)
                        {
                            cukier=0.5;
                            cena += cukier;
                            Console.WriteLine("Cena to " + cena+" zł");
                            break;
                        }
                        else
                        {
                            cukier = 0;
                            Console.WriteLine("Cena to " + cena+" zł");
                            break;
                            
                        }
                    }
                case 2:
                    {
                        cena = 1.00;
                        Console.WriteLine("Wybrano herbatę");
                        Console.WriteLine("Chcesz kupić cukier za 0,5 zł?");
                        Console.WriteLine("1. Tak");
                        Console.WriteLine("2. Nie");
                        w1 = int.Parse(Console.ReadLine());
                        if (w1 == 1)
                        {
                            cukier = 0.5;
                            cena += cukier;
                            Console.WriteLine("Cena to: " + cena + " zł");
                            break;
                        }
                        else
                        {
                            cukier = 0;
                            Console.WriteLine("Cena to: " + cena + " zł");
                            break;
                        }
                    }
                case 3:
                    {
                        cena = 2.00;
                        Console.WriteLine("Wybrano czekoladę");
                        Console.WriteLine("Chcesz kupić cukier za 0,5 zł?");
                        Console.WriteLine("1. Tak");
                        Console.WriteLine("2. Nie");
                        w1 = int.Parse(Console.ReadLine());
                        if (w1 == 1)
                        {
                            cukier=0.5;
                            cena += cukier;
                            Console.WriteLine("Cena to: " + cena + " zł");
                            break;
                        }
                        else
                        {
                            cukier = 0;
                            Console.WriteLine("Cena to: " + cena + " zł");
                            break;
                        }
                    }
            }
            Console.ReadLine();
        }
    }
}
