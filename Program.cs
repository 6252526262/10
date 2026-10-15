//*********************************************************************************************
//*практическая работа №10 варииант 8                                                          *
//*Выполнил Тарасов Александр группа 2ИСПд                                                    *
//*задание составить программу для нахождения минимального четного элемента массива           *
//*********************************************************************************************
using System;


{
    static void Main()
    {
        bool runAgain = true;

        do
        {
            try
            {
                // 1. создание счетчика и случайных чисел
                Random rnd = new Random();
                int count = 0;
                Console.Title = "практическая10";

                Console.BackgroundColor = ConsoleColor.Blue
;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("здравствуйте");

                // 2. создание массива
                double[,] a = new double[3, 3];

                Console.WriteLine("Массив:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // заполнение массива
                        a[i, j] = Math.Round(rnd.NextDouble() * 50 - 25, 1);
                        Console.Write(a[i, j] + "\t");

                        // поиск отрицательных чисел
                        if (a[i, j] < 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine();
                }

                // 3.
                Console.WriteLine();
                Console.WriteLine("Количество отрицательных: " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла неизвестная ошибка :( ");
            }

            // Многократное выполнение без повторного запуска
            Console.WriteLine();
            Console.Write("Хотите выполнить программу еще раз? Нажмите (y): ");
            string choice = Console.ReadLine();

            if (choice.ToLower() != "y" && choice.ToLower() != "н" && choice.ToLower() != "h")
            {
                runAgain = false;
            }

        } while (runAgain);

        Console.WriteLine("Программа завершена.");
    }
}