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

    static long PermutationCount(long n, long r)
    {
        return Fact(n)/Fact(n-r);
    }

    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long r = long.Parse(Console.ReadLine());
        Console.WriteLine(PermutationCount(n, r));
    }
}