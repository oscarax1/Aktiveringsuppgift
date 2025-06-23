public class Bok : Produkt
{
    public string Författare { get; set; }

    public override void VisaInfo()
    {
        Console.WriteLine($"Bok: {Namn}, Pris: {Pris} kr, Författare: {Författare}");
    }
}