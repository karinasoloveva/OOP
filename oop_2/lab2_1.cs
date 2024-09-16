using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Задати розмір колекцій
        int length = 10; // Наприклад, довжина 10
        List<int> collection1 = GenerateRandomNumbers(length, 1, 10);
        List<int> collection2 = GenerateRandomNumbers(length, 1, 10);

        Console.WriteLine("Collection 1:");
        PrintList(collection1);

        Console.WriteLine("Collection 2:");
        PrintList(collection2);

        // Отримати третю колекцію
        List<int> collection3 = GetMinElements(collection1, collection2);

        Console.WriteLine("Collection 3 (min elements):");
        PrintList(collection3);
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

    // Отримує третю колекцію, де кожен елемент є найменшим з двох відповідних елементів
    static List<int> GetMinElements(List<int> collection1, List<int> collection2)
    {
        List<int> minCollection = new List<int>();

        for (int i = 0; i < collection1.Count; i++)
        {
            minCollection.Add(Math.Min(collection1[i], collection2[i]));
        }

        return minCollection;
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
