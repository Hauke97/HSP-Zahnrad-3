using System;

namespace HSP_Zahnrad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Parametereingabe
            Console.WriteLine("Geben Sie den Modul ein");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Zähnezahl ein");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie den Teilkreisdurchmesser ein");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Breite ein");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Winkel a ein");
            double a = Convert.ToDouble(Console.ReadLine());


            //Berechnungen
            double p = Math.PI * m;
            double c = 0.167 * m;
            double df = d - 2 * (m + c);
            double da = m * (z + 2);
            double hf = m + c;
            double ha = m;
            double R = Math.Cos(a);
            double db = z * m * R;
            double h = 2 * m + c;
            
            //Ausgabe
            Console.WriteLine("Ergebnis für die Zahnhöhe:" + h + "mm");
            Console.WriteLine("Ergebnis für die Zahnkopfhöhe:" + ha + "mm");
            Console.WriteLine("Ergebnis für die Zahnfußöhe:" + hf + "mm");
            Console.WriteLine("Ergebnis für die Teilung:" + p);
            Console.WriteLine("Ergebnis für den Grundkreisdurchmesser:" + db + "mm ");
            Console.WriteLine("Ergebnis für den Kopfkreisdurchmesser:" + da + "mm");
            Console.WriteLine("Ergebnis für den Fußkreisdurchmesser:" + df+"mm");

        }
    }
}
