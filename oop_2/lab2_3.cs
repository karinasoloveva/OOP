using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Задати розмір колекції
        int N = 10; // Наприклад, 10 чисел
        List<int> numbers = GenerateRandomNumbers(N, -5, 5);

        Console.WriteLine("Original List:");
        PrintList(numbers);

        // Знайти максимальне число
        int maxNumber = FindMax(numbers);
        Console.WriteLine($"Maximum number: {maxNumber}");

        // Видалити всі максимальні числа
        RemoveAllMax(numbers, maxNumber);

        Console.WriteLine("List after removing max values:");
        PrintList(numbers);
    }

    // Генерує колекцію випадкових чисел в заданому інтервалі
    static List<int> GenerateRandomNumbers(int count, int minValue, int maxValue)
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < count; i++)
        {
            numbers.Add(random.Next(minValue, maxValue + 1));
        }

        return numbers;
    }

    // Знаходить максимальне число в колекції
    static int FindMax(List<int> numbers)
    {
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }

    // Видаляє всі екземпляри максимального числа з колекції
    static void RemoveAllMax(List<int> numbers, int maxNumber)
    {
        numbers.RemoveAll(num => num == maxNumber);
    }

    // Друкує всі елементи списку
    static void PrintList(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
