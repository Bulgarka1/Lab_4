using System;
class Program
{
    static void Main(string[] args)
    {
        int x=Convert.ToInt32(Console.ReadLine());
        int y= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Funcdoub(x, y));

        char e = char.Parse(Console.ReadLine());
        char q = char.Parse(Console.ReadLine());


        Console.WriteLine(Funcchar(e, q));
    }

    static double Funcdoub(double x, double y)
    {

        double a = 2 * x + 0.5;
        double b = -Math.Sqrt(y);
        double result = Math.Max(a, b);
        return result;
    }

    static int Funcchar(char e, char q)
    {
        int k = 5 + 30 * e;
        int j = -q - (13 / 3);
        int l = Math.Max(k, j);
        return l;
    }



}
