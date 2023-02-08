using System;

class Program
{
    static long Fact(long n)
    {
        if(n <= 1)
        {
            return 1;
        }
        else
        {
            return n * Fact(n-1);
        }
    }

    static long CombinationCount(long n, long r)
    {
        return Fact(n)/(Fact(n-r)*Fact(r));
    }

    static double Binomial(long n, long x, double p)
    {
        return CombinationCount(n, x)*Math.Pow(p, x)*Math.Pow(1-p, n-x);
    }

    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long x = long.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        Console.WriteLine(Binomial(n, x, p));
    }
}