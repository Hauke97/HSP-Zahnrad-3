using System;

namespace HSP_Zahnrad_3
{
    class Program
    {
        static void Main(string[] args)
        {
// Updated upstream
            
            //Parametereingabe
            Console.WriteLine("Geben Sie den Modul ein");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Zähnezahl ein");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie den Teilkreisdurchmesser ein");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Breite ein");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Zähnezahl ein");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Winkel a ein");
            double a = Convert.ToDouble(Console.ReadLine());



            double p = Math.Pi * m;
            double c = 0.167 * m;
            double df = d - 2 * (m + c);
            double da = m * (z + 2);
            double hf = m + c;
            double ha = m;
            double R = Math.Cos(a);

            double db = z * m * R;

            //Ausgabe
            Console.WriteLine("Ergebnis für die Zahnkopfhöhe:" + ha + "cm");
            Console.WriteLine("Ergebnis für die Zahnfußöhe:" + hf + "cm");
            Console.WriteLine("Ergebnis für die Teilung:" + p);
            Console.WriteLine("Ergebnis für den Grundkreisdurchmesser:" + db + "cm ");
            Console.WriteLine("Ergebnis für den Kopfkreisdurchmesser:" + da + "cm");

//Stashed changes
        }
    }
}
