// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        PrintSomething();
        TryCatchMethod();

    }

    private static void TryCatchMethod()
    {
        try
        {
            string numString = "10";
            int num = Int32.Parse(numString);  //converting string to integer
            Console.WriteLine($"Contents of num: {num}");
        }
        catch (Exception error) // -most common catch version
        {

            Console.WriteLine(error.Message);
        }
        //catch(FormatException) //version 2 format your own error msg
        //{
        //    Console.WriteLine("Error: num needs a valid value!");

        //}
    }

    static void PrintSomething()
    {
        Console.WriteLine("Print Something!");
    }
}
