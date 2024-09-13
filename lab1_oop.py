using System;

class Program
{
    static void Main()
    {
    Console.Write("Введіть рядок:")
    string input = Console.ReadLine()
    string cleanedInput = input.ToLower().Replace(" ", ""); // Ігноруємо пробіли та реєстр
    string reversedInput = Reverse(cleanedInput);
    
    if (cleanedInput == reversedInput)
    {
        Console.WriteLine("Рядок є паліндромом.");
    }
    else
    {
        Console.WriteLine( "Рядок не є паліндромом.");
    }
    }
    static string Reverse (string s)
    {
    charl. array = s.ToCharArrayO;
    Arrav.Reverse(array);
    return new string(array);
    }
}