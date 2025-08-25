
using System;

namespace DeinProjektname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool weiter = true;

            while (weiter)
            {
                Console.WriteLine("\n=== Menü ===");
                Console.WriteLine("1 = ggT berechnen");
                Console.WriteLine("2 = kgV berechnen");
                Console.WriteLine("0 = Ende");
                Console.Write("Deine Auswahl: ");
                string wahl = Console.ReadLine();

                if (wahl == "0")
                {
                    weiter = false; // Programm beenden
                }
                else if (wahl == "1" || wahl == "2")
                {
                    int a = MyMath.ReadInt("Gib die erste Zahl ein");
                    int b = MyMath.ReadInt("Gib die zweite Zahl ein");

                    if (wahl == "1")
                    {
                        int ggt = MyMath.Calc_ggT(a, b);
                        MyMath.ShowResult("ggT", a, b, ggt);
                    }
                    else if (wahl == "2")
                    {
                        int kgv = MyMath.Calc_kgV(a, b);
                        MyMath.ShowResult("kgV", a, b, kgv);
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, bitte wähle 0, 1 oder 2!");
                }
            }

            Console.WriteLine("Programm beendet.");
        }
    }
}
