using System;
using System.Collections.Generic;
using System.Text;

namespace FelhasznaloFiok
{
    public class Felhasznalo
    {
        private string jelszo = "123456";

        public string Felhasznalonev { get; set; }

        public void JelszoModositas(string regiJelszo, string ujJelszo)
        {
            if (regiJelszo != jelszo)
            {
                Console.WriteLine("Hiba: A megadott régi jelszó helytelen!");
            }
            else if (ujJelszo.Length < 6)
            {
                Console.WriteLine("Hiba: Az új jelszónak legalább 6 karakter hosszúnak kell lennie!");
            }
            else
            {
                jelszo = ujJelszo;
                Console.WriteLine("Siker: A jelszó sikeresen módosítva lett!");
            }
        }
    }
}
