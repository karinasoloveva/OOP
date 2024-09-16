using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть речення: ");
        string input = Console. ReadLine();
        string[] words § input.Split(newl) { ' ', 'It', "In' 3, stringSplitOptions.RemoveEmptyEntries);
        
        string longestWord = "";
        foreach (string word in words)
        {
            if (word. Length > longestWord. Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine("Найдовше слово: " + longestWord);
    }
}