using System;
using System.Collections.Generic;
using System.Text;

namespace Raktarkezelo
{
    public class RaktarElem
    {
        private int dbSzam = 0;

        public string CikkNev { get; set; }

        public static double AfaKulcs = 0.27;

        public int DbSzam
        {
            get { return dbSzam; }
        }

        public void Bevetelezes(int db)
        {
            if (db <= 0)
            {
                Console.WriteLine("Figyelmeztetés: A bevételezett mennyiségnek pozitívnak kell lennie!");
            }
            else
            {
                dbSzam += db;
                Console.WriteLine($"Sikeres bevételezés: +{db} db. Jelenlegi készlet: {dbSzam} db");
            }
        }

        public void Kiadas(int db)
        {
            if (db <= 0)
            {
                Console.WriteLine("Figyelmeztetés: A kiadni kívánt mennyiségnek pozitívnak kell lennie!");
            }
            else if (dbSzam - db < 0)
            {
                Console.WriteLine($"Figyelmeztetés: Nincs elegendő készlet! (Kért: {db} db, Elérhető: {dbSzam} db)");
            }
            else
            {
                dbSzam -= db;
                Console.WriteLine($"Sikeres kiadás: -{db} db. Jelenlegi készlet: {dbSzam} db");
            }
        }
        public static double BruttoArSzamitas(double nettoAr)
        {
            return nettoAr * (1 + AfaKulcs);
        }
    }
}
