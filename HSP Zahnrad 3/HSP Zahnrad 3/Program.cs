using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSP_Zahnrad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ende;
            do
            {
                //Parametereingabe
                Console.WriteLine("Wenn Grundkreisdurchmesser gesucht wird, drücken Sie 1");
                Console.WriteLine("Wenn Zahnkopfhöhe gesucht wird, drücken Sie 2");
                Console.WriteLine("Wenn Zahnfußhöhe gesucht wird, drücken Sie 3");
                Console.WriteLine("Wenn Fußkreisdurchmesser gesucht wird, drücken Sie 4");
                Console.WriteLine("Wenn Teilung gesucht wird, drücken Sie 5");
                Console.WriteLine("Wenn Zahnhöhe gesucht wird, drücken Sie 6");


                int Eingabe = 0;

                Eingabe = Convert.ToInt32(Console.ReadLine());



                if (Eingabe == 1)


                {
                    Console.WriteLine("Geben Sie den Modul ein");
                    double m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Geben Sie die Zähnezahl ein");
                    int z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geben Sie den Winkel ein");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double R = Math.Cos(a);
                    double db = z * m * R;
                    Console.WriteLine("Ergebnis für den Grundkreisdurchmesser:" + db + "mm ");

                }

                else if (Eingabe == 2)

                {
                    Console.WriteLine("Geben Sie den Modul ein");
                    double m = Convert.ToDouble(Console.ReadLine());
                    double ha = m;
                    Console.WriteLine("Ergebnis für die Zahnkopfhöhe:" + ha + "mm");

                }

                else if (Eingabe == 3)

                {
                    Console.WriteLine("Geben Sie den Modul ein");
                    double m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Geben Sie das Kofspiel ein ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double hf = m + c;
                    Console.WriteLine("Ergebnis für die Zahnfußöhe:" + hf + "mm");


                }

                else if (Eingabe == 4)

                {
                    Console.WriteLine("Geben Sie den Modul ein");
                    double m = Convert.ToDouble(Console.ReadLine());
                    double c = 0.167 * m;
                    Console.WriteLine("Geben Sie den Teilkreisdurchmesser ein");
                    double d = Convert.ToDouble(Console.ReadLine());
                    double df = d - 2 * (m + c);
                    Console.WriteLine("Ergebnis für den Fußkreisdurchmesser:" + df + "mm");
                }
                else if (Eingabe == 5)
                {
                    Console.WriteLine("Geben Sie den Modul ein");
                    double m = Convert.ToDouble(Console.ReadLine());
                    double p = Math.PI * m;
                    Console.WriteLine("Ergebnis für die Teilung:" + p);

                }

                else if (Eingabe == 6)

                {
                    Console.WriteLine("Geben Sie den Modul ein");
                    double m = Convert.ToDouble(Console.ReadLine());
                    double c = 0.167 * m;
                    double h = 2 * m + c;
                    Console.WriteLine("Ergebnis für die Zahnhöhe:" + h + "mm");


                }
                Console.WriteLine("Wenn Sie das Programm beenden möchten, geben Sie Ende ein. Andernfalls können weitere Berechnungen ausgeführt werden.");
                Ende = Console.ReadLine();
                Console.ReadKey();



            } while (Ene != "Ende");
        }
    }
}
