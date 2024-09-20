using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = null;
            int N;

            Console.WriteLine("Оберіть спосіб введення даних:");
            Console.WriteLine("1. Ввести з клавіатури");
            Console.WriteLine("2. Зчитати з файлу");
            Console.WriteLine("3. Згенерувати випадкові числа");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Введіть розмір масиву: ");
                    N = int.Parse(Console.ReadLine());
                    array = new int[N];
                    Console.WriteLine("Введіть елементи масиву:");
                    for (int i = 0; i < N; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    break;

                case "2":
                    Console.Write("Введіть шлях до файлу: ");
                    string path = Console.ReadLine();
                    array = Array.ConvertAll(File.ReadAllLines(path), int.Parse);
                    break;

                case "3":
                    Console.Write("Введіть розмір масиву: ");
                    N = int.Parse(Console.ReadLine());
                    Random rnd = new Random();
                    array = new int[N];
                    for (int i = 0; i < N; i++)
                    {
                        array[i] = rnd.Next(-100, 101); // Генерація випадкових чисел від -100 до 100
                    }
                    break;

                default:
                    Console.WriteLine("Невірний вибір!");
                    return;
            }

            // Виконання запитів
            Console.WriteLine("\nОригінальний масив:");
            PrintArray(array);

            // Запит 1: Кількість негативних, позитивних чисел та середнє арифметичне
            CountNegativesAndPositives(array);
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void CountNegativesAndPositives(int[] array)
        {
            int negativeCount = 0, positiveCount = 0;
            double sum = 0;

            foreach (var item in array)
            {
                if (item < 0)
                {
                    negativeCount++;
                }
                else if (item > 0)
                {
                    positiveCount++;
                }
                sum += item;
            }

            double average = sum / array.Length;

            Console.WriteLine($"Кількість від’ємних чисел: {negativeCount}");
            Console.WriteLine($"Кількість додатних чисел: {positiveCount}");
            Console.WriteLine($"Середнє арифметичне всіх чисел: {average:F2}");
        }
    }
}