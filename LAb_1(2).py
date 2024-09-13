using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string input = Console. ReadLine();
        if (string. IsNuflOrEmpty (input)) return;

        char lastChar = input[input.Length - 1];
        string replacement = "!!";
        string result = input. Replace (lastChar.ToString(), replacement);
        Console.WriteLine ("Модифікований рядок: " + result);
    }
}