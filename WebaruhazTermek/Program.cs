
using WebaruhazTermek;

namespace WebaruhazTermek
{
    class Program
    {
        static void Main(string[] args)
        {
            Termek termek1 = new Termek();
            termek1.Nev = "Vezeték nélküli egér";
            termek1.Egysegar = 4500;
            termek1.Keszlet = 12;

            Termek termek2 = new Termek();
            termek2.Nev = "Promóciós kulcstartó";
            termek2.Egysegar = -500; 
            termek2.Keszlet = -5;    

            Console.WriteLine("--- 1. Termék (Érvényes adatok) ---");
            Console.WriteLine($"Név: {termek1.Nev}");
            Console.WriteLine($"Egységár: {termek1.Egysegar} Ft");
            Console.WriteLine($"Készlet: {termek1.Keszlet} db\n");

            Console.WriteLine("--- 2. Termék (Érvénytelen adatok korrigálva) ---");
            Console.WriteLine($"Név: {termek2.Nev}");
            Console.WriteLine($"Egységár: {termek2.Egysegar} Ft");
            Console.WriteLine($"Készlet: {termek2.Keszlet} db");

            Console.ReadLine();
        }
    }
}
