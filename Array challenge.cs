using System;

class Program
{
    static void Main()
    {
        // Array of scores
        int[] scores = { 90, 70, 80, 95, 60 };

        // Print scores before clearing
        Console.WriteLine("Before:");
        foreach (var score in scores)
        {
            Console.WriteLine($"-- {score}");
        }

        // Clear scores from index 1 to 3 (2 elements)
        Array.Clear(scores, 1, 2);

        // Print scores after clearing
        Console.WriteLine("After clearing:");
        foreach (var score in scores)
        {
            Console.WriteLine($"-- {score}");
        }

        // Add new values to the cleared positions
        scores[1] = 50;
        scores[2] = 40;

        // Print scores after adding new values
        Console.WriteLine("After adding new values:");
        foreach (var score in scores)
        {
            Console.WriteLine($"-- {score}");
        }
    }
}
