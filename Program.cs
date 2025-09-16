using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- ToDo App ---");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Показать задачи");
            Console.WriteLine("3. Удалить задачу");
            Console.WriteLine("4. Выйти");
            Console.Write("Выбери действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введи задачу: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Задача добавлена!");
                    break;

                case "2":
                    Console.WriteLine("\nСписок задач:");
                    if (tasks.Count == 0) Console.WriteLine("Нет задач");
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                    }
                    break;

                case "3":
                    Console.Write("Номер задачи для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= tasks.Count)
                    {
                        tasks.RemoveAt(num - 1);
                        Console.WriteLine("🗑 Задача удалена!");
                    }
                    else Console.WriteLine("Неверный номер");
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("До свидания!");
                    break;

                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
}
