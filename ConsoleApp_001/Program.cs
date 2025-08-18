namespace ConsoleApp_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 2;
            int b = 3;
            int summe = MyMath.Add(a, b);
            Console.WriteLine($"Summe von {a} und {b} = {summe}");

            int c = 6;
            int d = 7;
            int resultat = MyMath.Substract(c, d);
            Console.WriteLine($"Resultat von {c} minus {d} = {resultat}");
        }
    }
}
