// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        int a = 20, b = 30;
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a + b;      
        b = a - b;     
        a = a - b;   
        Console.Write("After swap a= " + a + " b= " + b);
    }
}
