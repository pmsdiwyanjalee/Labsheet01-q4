using System;

class Labsheet04
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");

        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int n))
        {
            PrintFibonacciSeries(n);
        }
        else
        {
            Console.WriteLine("ERROR: Please enter a valid integer.");
        }
    }

    static void PrintFibonacciSeries(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("ERROR: Please enter a non-negative integer.");
            return;
        }
        int a = 0, b = 1;
        Console.Write($"Fibonacci Series (first {n} terms): {a}, {b}");

        for (int i = 2; i < n; i++)
        {
            int nextTerm = a + b;
            Console.Write($", {nextTerm}");

            a = b;
            b = nextTerm;
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}

