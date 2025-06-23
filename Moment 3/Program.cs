using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Produkt stol = new Produkt
        {
            Namn = "Kontorsstol",
            Pris = 899.90
        };

        Bok bok = new Bok
        {
            Namn = "C# för nybörjare",
            Pris = 299.50,
            Författare = "Anna Svensson"
        };

        List<Produkt> produkter = new List<Produkt> { stol, bok };

        foreach (Produkt produkt in produkter)
        {
            produkt.VisaInfo();
        }

        Console.ReadLine(); 
    }
}