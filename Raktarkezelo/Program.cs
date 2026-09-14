using Raktarkezelo;


namespace Raktarkezelo
{
    class Program
    {
        static void Main(string[] args)
        {
            RaktarElem termek = new RaktarElem();
            termek.CikkNev = "USB-C Kábel (2m)";

            Console.WriteLine($"=== Raktárelem kezelése: {termek.CikkNev} ===");
            Console.WriteLine($"Kezdő készlet: {termek.DbSzam} db\n");

            Console.WriteLine("--- Bevételezés ---");
            termek.Bevetelezes(-5); 
            termek.Bevetelezes(50); 
            Console.WriteLine();


            Console.WriteLine("--- Kiadás ---");
            termek.Kiadas(20); 
            termek.Kiadas(40);  
            termek.Kiadas(-10);
            Console.WriteLine();

            Console.WriteLine("--- Árszámítás (Statikus metódus) ---");
            double nettoAr = 3500;
            double bruttoAr = RaktarElem.BruttoArSzamitas(nettoAr);

            Console.WriteLine($"ÁFA kulcs: {RaktarElem.AfaKulcs * 100}%");
            Console.WriteLine($"Nettó ár: {nettoAr} Ft");
            Console.WriteLine($"Bruttó ár: {bruttoAr} Ft");

            Console.ReadLine();
        }
    }
}
