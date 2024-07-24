using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a HashSet to store unique words
        HashSet<string> uniqueWords = new HashSet<string>();

        // Array of words
        string[] words = { "apple", "banana", "apple", "orange", "banana", "grape" };

        // Add each word to the HashSet, converting to lowercase
        foreach (string word in words)
        {
            uniqueWords.Add(word.ToLower());
        }

        // Print the number of unique words
        Console.WriteLine("Unique words: " + uniqueWords.Count);
    }
