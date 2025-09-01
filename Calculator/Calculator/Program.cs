using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int LastResult { get; private set; } = 0;
        public bool HasResult { get; private set; } = false;

        // vier grundrechenarten (2 parameter)
        public int Add(int a, int b) { LastResult = a + b; HasResult = true; return LastResult; }
        public int Sub(int a, int b) { LastResult = a - b; HasResult = true; return LastResult; }
        public int Mul(int a, int b) { LastResult = a * b; HasResult = true; return LastResult; }
        public int Div(int a, int b)
        {
            if (b == 0) { Console.WriteLine("Fehler: Division durch 0 nicht erlaubt."); return LastResult; }
            LastResult = a / b; HasResult = true; return LastResult;
        }

        // overloads (1 parameter: nutzt LastResult als ersten operand)
        public int Add(int b) { if (!HasResult) Console.WriteLine("Hinweis: kein zwischenergebnis, 0 wird benutzt."); return Add(LastResult, b); }
        public int Sub(int b) { if (!HasResult) Console.WriteLine("Hinweis: kein zwischenergebnis, 0 wird benutzt."); return Sub(LastResult, b); }
        public int Mul(int b) { if (!HasResult) Console.WriteLine("Hinweis: kein zwischenergebnis, 0 wird benutzt."); return Mul(LastResult, b); }
        public int Div(int b) { if (!HasResult) Console.WriteLine("Hinweis: kein zwischenergebnis, 0 wird benutzt."); return Div(LastResult, b); }
    }

    internal class Program
    {
        static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                string s = Console.ReadLine() ?? "";
                if (int.TryParse(s, out int value)) return value;
                Console.Write("Bitte eine ganze zahl eingeben: ");
            }
        }

        static void Main()
        {
            var calc = new Calculator();
            Console.WriteLine("=== Einfacher Calculator (int) ===");

            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("Menue: +  -  *  /  q (beenden)");
                if (calc.HasResult) Console.WriteLine($"Letztes ergebnis: {calc.LastResult}");

                Console.Write("Waehle eine operation: ");
                string op = Console.ReadLine() ?? "";
                if (op == "q") break;

                bool useLast = false;
                if (calc.HasResult)
                {
                    Console.Write("Mit letztem ergebnis als ersten operand rechnen? (j/n): ");
                    useLast = (Console.ReadLine() ?? "").Trim().ToLower() == "j";
                }

                if (useLast)
                {
                    int b = ReadInt("Zweiter operand: ");
                    switch (op)
                    {
                        case "+": Console.WriteLine($"Ergebnis: {calc.Add(b)}"); break;
                        case "-": Console.WriteLine($"Ergebnis: {calc.Sub(b)}"); break;
                        case "*": Console.WriteLine($"Ergebnis: {calc.Mul(b)}"); break;
                        case "/": Console.WriteLine($"Ergebnis: {calc.Div(b)}"); break;
                        default: Console.WriteLine("Unbekannte operation."); break;
                    }
                }
                else
                {
                    int a = ReadInt("Erster operand: ");
                    int b = ReadInt("Zweiter operand: ");
                    switch (op)
                    {
                        case "+": Console.WriteLine($"Ergebnis: {calc.Add(a, b)}"); break;
                        case "-": Console.WriteLine($"Ergebnis: {calc.Sub(a, b)}"); break;
                        case "*": Console.WriteLine($"Ergebnis: {calc.Mul(a, b)}"); break;
                        case "/": Console.WriteLine($"Ergebnis: {calc.Div(a, b)}"); break;
                        default: Console.WriteLine("Unbekannte operation."); break;
                    }
                }
            }

            Console.WriteLine("Tschuess!");
        }
    }
}
