﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
	public class PrimeFactor
	{

		// A function to print all prime no.
		public static void primeFactors(int n)
		{
			// Print the number of 2s that divide n
			while (n % 2 == 0)
			{
				Console.Write(2 + " ");
				n /= 2;
			}

			// n must be odd at this point So we can skip one element (Note i = i +2)
			for (int i = 3; i <= Math.Sqrt(n); i += 2)
			{
				// While i divides n, print i and divide n
				while (n % i == 0)
				{
					Console.Write(i + " ");
					n /= i;
				}
			}

			// This condition is to handle the case when n is a prime number greater than 2
			if (n > 2)
				Console.Write(n);
		}

		// Driver Code
		public static void Main()
		{
			int n = 8;
			primeFactors(n);
		}

	}
