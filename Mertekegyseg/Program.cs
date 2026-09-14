using Mertekegyseg;

namespace Mertekegyseg
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = 5.5;
            double meter = Atvalto.KmBolMeter(km);
            Console.WriteLine($"--- Statikus metódus tesztelése ---");
            Console.WriteLine($"{km} km = {meter} méter\n");

            Atvalto merfoldAtvalto = new Atvalto();

            merfoldAtvalto.Szorzo = 1.60934;

            double merfold = 10;
            double atvaltomerfold = merfoldAtvalto.EgyediAtvaltas(merfold);

            Console.WriteLine($"--- Példányosított metódus tesztelése ---");
            Console.WriteLine($"Beállított szorzó: {merfoldAtvalto.Szorzo}");
            Console.WriteLine($"{merfold} mérföld = {atvaltomerfold} km");

            Console.ReadLine();
        }
    }
}