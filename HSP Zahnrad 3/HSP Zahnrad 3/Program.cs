using System;

namespace HSP_Zahnrad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie den Modul ein");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Zähnezahl ein");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie den Teilkreisdurchmesser ein");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Breite ein");
            double b = Convert.ToDouble(Console.ReadLine());
        }
    }
}
