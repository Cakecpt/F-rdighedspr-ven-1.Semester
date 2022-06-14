using System;

namespace Færdighedsprøven_1.Semester
{
    class Program
    {
        static void Main(string[] args)
        {
            kreds KredsA = new kreds("Jens Gruppe", "ID: Y", "Adresse: Jensens gade", 5);
            kreds KredsB = new kreds("Vibekes Gruppe", "ID: Z", "Adresse: Vibeke Gade", 7);
            kreds KredsC = new kreds("Min Gruppe", "ID: X", "Adresse: Gruppe gade", 3);

            badetidsperiode bad1 = new badetidsperiode(2,6);
            bad1.PrintTime();
            badetidsperiode bad2 = new badetidsperiode(2,4);
            bad2.PrintTime();
            badetidsperiode bad3 = new badetidsperiode(2,1);
            bad3.PrintTime();

            Console.WriteLine("FDF Kredser");
            Console.WriteLine($"Første Kreds: {KredsA.Navn}, {KredsA.id}, {KredsA.A}, {KredsA.D},");
            bad1.PrintTime();
            Console.WriteLine($"Anden Kreds: {KredsB.Navn} {KredsB.id}, {KredsB.A}, {KredsB.D}");
            bad2.PrintTime();
            Console.WriteLine($"Tredje Kreds: {KredsC.Navn}, {KredsC.id}, {KredsC.A}, {KredsC.D}");
            bad3.PrintTime();
        }
    }
}
