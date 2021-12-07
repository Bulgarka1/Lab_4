using System;

namespace ConsoleApp2
{
    class Program
    {
        static double Method(double a)
        {
            double s = (3 - a) / 7.0;
            return s;
        }
        static double Rec(double k)
        {


            if (k == 1)
            {
                return Method(k);
            }
            else if (k == 3)
            {
                return 1;
            }
            else
            {
                return Method(k) * Rec(k - 1);
            }


        }
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());
            double s = Rec(n);


            Console.WriteLine(s);
            Console.ReadKey();
        }

    }
}
