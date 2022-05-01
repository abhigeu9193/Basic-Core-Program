// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/**********************************************
            alphabetacoder.com
C# program to check if a number is even or odd 
***********************************************/

using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variable
            int n;

            //take input
            Console.Write("Enter the number = ");
            n = Convert.ToInt32(Console.ReadLine());

            //check if n is even or odd
            if (n % 2 == 0)
                Console.WriteLine(n + " is even");
            else
                Console.WriteLine(n + " is odd");

           
            Console.ReadKey();
        }
    }
}








