using System;

class Program
{
    static void Main()
    {
        // Create a new Random object
        Random random = new Random();

        // Generate a random number of days until birthday
        int daysUntilBirthday = 5; // Changed to 5 for demonstration purposes

        // Initialize gift discount
        int giftDiscount = 0;

        // Check the number of days until birthday
        if (daysUntilBirthday == 0)
        {
            Console.WriteLine("Happy Birthday!");
        }
        else if (daysUntilBirthday == 1)
        {
            giftDiscount = 20;
            Console.WriteLine("Your birthday is tomorrow!");
            Console.WriteLine("Get " + giftDiscount + "% off on all gifts!");
        }
        else if (daysUntilBirthday <= 7)
        {
            giftDiscount = 15;
            Console.WriteLine("Your birthday is in " + daysUntilBirthday + " days.");
            Console.WriteLine("Get " + giftDiscount + "% off on all gifts!");
        }
        else if (daysUntilBirthday <= 14)
        {
            giftDiscount = 10;
            Console.WriteLine("Your birthday is in " + daysUntilBirthday + " days.");
            Console.WriteLine("Get " + giftDiscount + "% off on all gifts!");
        }
        else
        {
            Console.WriteLine("Your birthday is in " + daysUntilBirthday + " days.");
            Console.WriteLine("Start planning your birthday celebration!");
        }

        Console.ReadLine();
    }
}
