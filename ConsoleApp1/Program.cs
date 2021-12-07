using System;

namespace ConsoleApp1
{
    class Program
    {
        static double Method(double k)
        {
            double m = (k * k * k) / 3;
            return m;
        }
        static double Rec(double k)
        {
            if (k == 0)
            {
                return Method(k);
            }
            else
            {
                return Method(k) + Rec(k - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double m = Rec(n);

            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
