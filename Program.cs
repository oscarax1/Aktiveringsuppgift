using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Produkt> produkter = new List<Produkt>();
        bool kör = true;

        while (kör)
        {
            Console.Write("Ange produktnamn (eller skriv 'stopp' för att avsluta): ");
            string namn = Console.ReadLine();

            if (namn.ToLower() == "stopp")
            {
                kör = false;
                continue;
            }

            Console.Write("Ange pris: ");
            double pris = COnvert.ToDouble(Console.ReadLine());

            produkter.Add(new Produkt(namn, pris));
        }

        Console.WriteLine("\n--- Produktlista ---");
        foreach (Produkt p in produkter)
        {
            p.VisaInfo();
        }
    }
}