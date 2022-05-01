// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// C# code to find highest power
// of 2 smaller than or equal to n.
using System;

class Power
{
	public static int Powerof2(int n)
	{
		int res = 0;
		for (int i = n; i >= 1; i--)
		{
			// If i is a power of 2
			if ((i & (i - 1)) == 0)
			{
				res = i;
				break;
			}
		}
		return res;
	}

	// Driver Code
	static public void Main()
	{
		int n = 8;
		Console.WriteLine(Powerof2(n));
	}
}

