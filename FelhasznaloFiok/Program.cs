using FelhasznaloFiok;

namespace FelhasznaloFiok
{
    class Program
    {
        static void Main(string[] args)
        {
            Felhasznalo user = new Felhasznalo();
            user.Felhasznalonev = "kovacs_pete";

            Console.WriteLine($"Felhasználó létrehozva: {user.Felhasznalonev}\n");


            Console.WriteLine("--- Jelszómódosítás tesztelése ---\n");

            Console.WriteLine("1. Próbálkozás (hibás régi jelszó):");
            user.JelszoModositas("rosszJelszo", "ujJelszo123");
            Console.WriteLine();

            Console.WriteLine("2. Próbálkozás (túl rövid új jelszó):");
            user.JelszoModositas("123456", "123");
            Console.WriteLine();

            Console.WriteLine("3. Próbálkozás (helyes adatok):");
            user.JelszoModositas("123456", "ujBiztonsagosJelszo123");
            Console.WriteLine();

            Console.WriteLine("4. Módosítás ellenőrzése az új jelszóval:");
            user.JelszoModositas("ujBiztonsagosJelszo123", "masikSikeresJelszo");

            Console.ReadLine();
        }
    }
}
