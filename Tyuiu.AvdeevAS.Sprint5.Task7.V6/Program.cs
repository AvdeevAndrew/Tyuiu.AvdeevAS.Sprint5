using System;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task7.V6.Lib;

namespace Tyuiu.AvdeevAS.Sprint5.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #5                              *");
            Console.WriteLine("* Тема: Работа с файлами                                                 *");
            Console.WriteLine("*                              Задание #7                                 *");
            Console.WriteLine("*                              Вариант #6                                 *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");

            // Путь к файлу
            string directory = @"C:\DataSprint5";
            string inputFileName = "InPutDataFileTask7V6.txt";
            string inputFilePath = Path.Combine(directory, inputFileName);

            Console.WriteLine("                               ИСХОДНЫЕ ДАННЫЕ                             ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Путь к входному файлу: {inputFilePath}");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Замена данных и сохранение результата
                string outputFilePath = ds.LoadDataAndSave(inputFilePath);

                // Вывод результата
                Console.WriteLine("                               РЕЗУЛЬТАТ:                                  ");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"Результат сохранен в файл: {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
