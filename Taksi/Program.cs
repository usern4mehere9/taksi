using System;

namespace Taksi
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1, c2, c3, a, b, c;

            c1 = double.Parse(Console.ReadLine());
            c2 = double.Parse(Console.ReadLine());
            c3 = double.Parse(Console.ReadLine());

            a = c1 / 3;
            b = (c2 - a) / 2;
            c = c3 - (a + b);

            Console.WriteLine(Math.Round(a, 2));
            Console.WriteLine(Math.Round(b, 2));
            Console.WriteLine(Math.Round(c, 2));
        }
    }
}
