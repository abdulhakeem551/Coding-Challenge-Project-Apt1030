using System;

class Program
{
    static void Main()
    {
        int value = 1;

        // Increment
        value = Increment(value);
        Console.WriteLine("First Increment: " + value); // Output: 2

        value = Increment(value);
        Console.WriteLine("Second Increment: " + value); // Output: 3

        value = Increment(value);
        Console.WriteLine("Third Increment: " + value); // Output: 4

        // Decrement
        value = Decrement(value);
        Console.WriteLine("First Decrement: " + value); // Output: 3

        value = Decrement(value);
        Console.WriteLine("Second Decrement: " + value); // Output: 2

        value = Decrement(value);
        Console.WriteLine("Third Decrement: " + value); // Output: 1
    }

    static int Increment(int value)
    {
        return value + 1;
    }

    static int Decrement(int value)
    {
        return value - 1;
    }
}