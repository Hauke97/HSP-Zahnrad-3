using System;

namespace HSP_Zahnrad_3
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Geben Sie den Modul ein");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Zähnezahl ein");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie den Teilkreisdurchmesser ein");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Breite ein");
            double b = Convert.ToDouble(Console.ReadLine());
=======
            


            Console.WriteLine("Geben Sie den Modul ein");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie den Teilkreisdurchmesser ein");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie das Kopfspiel ein");
            double c = Convert.ToDouble(Console.ReadLine());
            double df = d - 2 * (m + c);
            Console.WriteLine("Ergebnis für df: " + df + "mm");

            Console.WriteLine("Gebenn Sie die Zähnezahl ein");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Winkel a ein");
            double a = Convert.ToDouble(Console.ReadLine());
            double R = Math.Cos(a);

            double db = z * m * R;
            Console.WriteLine("Ergebnis für db: " + db + "cm ");


>>>>>>> Stashed changes
        }
    }
}
