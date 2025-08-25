using System;

namespace Aufgabe_ggt_kgv
{
    internal class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int rest = a % b;
                a = b;
                b = rest;
            }
            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            return (a * b) / Calc_ggT(a, b);
        }

        public static int ReadInt(string text)
        {
            int zahl;
            do
            {
                Console.Write(text + ": ");
                string eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out zahl) && zahl > 0)
                {
                    return zahl;
                }
                else
                {
                    Console.WriteLine("Bitte eine positive ganze Zahl eingeben!");
                }
            } while (true);
        }

        public static void ShowResult(string type, int a, int b, int result)
        {
            Console.WriteLine($"{type} von {a} und {b} ist {result}");
        }
    }
}
