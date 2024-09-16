using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Задати розмір колекції
        int N = 10; // Наприклад, 10 чисел
        List<int> numbers = GenerateRandomNumbers(N, 5, 50);

        Console.WriteLine("Original List:");
        PrintList(numbers);

        // Знайти максимальне число
        int maxNumber = FindMax(numbers);
        Console.WriteLine($"Maximum number: {maxNumber}");

        // Вставити число -1 перед останнім максимальним числом
        InsertBeforeLastMax(numbers, maxNumber, -1);

        Console.WriteLine("List after inserting -1 before the last max value:");
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

    // Вставляє число перед останнім максимальним числом
    static void InsertBeforeLastMax(List<int> numbers, int maxNumber, int valueToInsert)
    {
        // Знайти останній індекс максимального числа
        int lastIndex = numbers.LastIndexOf(maxNumber);

        // Якщо максимальне число знайдено
        if (lastIndex != -1 && lastIndex > 0)
        {
            numbers.Insert(lastIndex, valueToInsert);
        }
        else if (lastIndex == 0) // Якщо максимальне число є першим елементом
        {
            numbers.Insert(0, valueToInsert);
        }
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
