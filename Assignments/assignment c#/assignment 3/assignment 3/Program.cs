using System;

class Program
{
    static void Main()
    {
        // Accept a word from the user
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        // Display the length of the word
        Console.WriteLine($"Length of the word: {word.Length}");
        // Display the reverse of the word
        Console.WriteLine($"Reverse of the word: {ReverseWord(word)}");
        // Accept two words from the user
        Console.Write("Enter the first word: ");
        string word1 = Console.ReadLine();
        Console.Write("Enter the second word: ");
        string word2 = Console.ReadLine();
        // Check if the two words are the same
        bool areSame = AreWordsSame(word1, word2);
        if (areSame)
            Console.WriteLine("The two words are the same.");
        else
            Console.WriteLine("The two words are different.");
    }
    static string ReverseWord(string input)

    {
        char[] charArray = input.ToCharArray();

        Array.Reverse(charArray);

        return new string(charArray);

    }
    static bool AreWordsSame(string word1, string word2)

    {
        return string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase);
    }

}
