using System;

class Program
{
    static void Main()
    {
        // Asking the user to input a character
        Console.WriteLine("Enter a character:");
        char myChar = Console.ReadKey().KeyChar;

        // Determining if the character is in the alphabet
        bool isLetter = Char.IsLetter(myChar);

        // Printing the result
        Console.WriteLine($"\n{myChar} is a letter: {isLetter}");

        // Asking the user to input a string of words
        Console.WriteLine("\nEnter a string of words:");
        string inputString = Console.ReadLine();

        // Asking the user to input a single word to search for
        Console.WriteLine("Enter a word to search for:");
        string wordToSearch = Console.ReadLine();

        // Checking if the input string contains the word to search for
        bool containsWord = inputString.Contains(wordToSearch);

        // Printing the result
        Console.WriteLine($"{wordToSearch} exists in {inputString}: {containsWord}");
    }
}