using System;

class Program
{
    static void Main()
    {
        // Create a new Random object
        Random dice = new Random();

        // Roll the dice three times
        int roll1 = dice.Next(1, 7); // Rolled a 4
        int roll2 = dice.Next(1, 7); // Rolled a 5
        int roll3 = dice.Next(1, 7); // Rolled a 4

        // Calculate the total
        int total = roll1 + roll2 + roll3;

        // Print the dice roll
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");

        // Check for triples or doubles
        if (roll1 == roll2 && roll2 == roll3)
        {
            Console.WriteLine("You rolled triples! +9 bonus to total!");
            total += 9;
        }
        else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            Console.WriteLine("You rolled doubles! +3 bonus to total!");
            total += 3;
        }

        // Check the total and print the result
        if (total >= 18)
        {
            Console.WriteLine("You win big!");
        }
        else if (total >= 12)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Sorry, you lose.");
        }

        Console.WriteLine($"Your total is: {total}");

        Console.ReadLine(); 
    }
}
