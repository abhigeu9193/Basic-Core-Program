// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class FlipFlop
{

	// Function to find count of head and tail
	public static Tuple<int, int> count_ht(char s,
										int N)
	{

		// Check if initially all thecoins are facing towards head
		Tuple<int, int> p = Tuple.Create(0, 0);

		if (s == 'H')
		{
			p = Tuple.Create((int)Math.Floor(N / 2.0),
							(int)Math.Ceiling(N / 2.0));
		}

		// Check if initially all the coinsare facing towards tail
		else if (s == 'T')
		{
			p = Tuple.Create((int)Math.Ceiling(N / 2.0),
							(int)Math.Floor(N / 2.0));
		}
		return p;
	}

	// Driver Code
	static void Main()
	{
		char C = 'H';
		int N = 3;
		Tuple<int, int> p = count_ht(C, N);

		Console.WriteLine("Head = " + p.Item1);
		Console.WriteLine("Tail = " + p.Item2);
	}
}

