// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public class Test
{
	public static void Main(string[] args)
	{
		int x, y, q, r;
		Console.Write("Enter first number:");
		x = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter second number:");
		y = Convert.ToInt32(Console.ReadLine());

		q = x / y;
		r = x % y;

		Console.WriteLine("Quotient is:" + q);
		Console.WriteLine("Remainder is:" + r);

	}
}
