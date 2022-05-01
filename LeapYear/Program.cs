// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// C# program to check
// for a leap year
using System;

class LeapYear
{

	static bool checkYear(int year)
	{
		// year is multiple of 400,then it is a leap year
		if (year % 400 == 0)
			return true;
       //year is multiple of 100,then it is not a leap year
		if (year % 100 == 0)
			return false;

		//a year is multiple of 4,then it is a leap year
		if (year % 4 == 0)
			return true;
		return false;
	}

	// Driver method
	public static void Main()
	{
		int year = 2020;
		Console.Write(checkYear(year) ? "Leap Year" :
								"Not a Leap Year");
	}

}

// This code is contributed by Sam007

