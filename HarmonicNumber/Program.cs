// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World
using System;
class HarmonicNumber
{
    // Function to return sum of 1/1 + 1/2 + 1/3 + ..+ 1/n
    static double sum(int n)
    {
        double i, s = 0;

        for (i = 1; i <= n; i++)
            s = s + 1 / i;

        return (double)s;
    }


    // Driven Program
    public static void Main()
    {
        int n = 10;
        Console.WriteLine("Sum is "
                           + sum(n));
    }
}

