using System;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task4.V5.Lib;

namespace Tyuiu.AvdeevAS.Sprint5.Task4.V05
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
            Console.WriteLine("*                              Задание #4                                 *");
            Console.WriteLine("*                              Вариант #5                                 *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");

            // Путь к файлу
            string directory = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask4V0.txt";
            string filePath = Path.Combine(directory, fileName);

            Console.WriteLine("                               ИСХОДНЫЕ ДАННЫЕ                             ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Путь к файлу: {filePath}");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Вычисление результата
                double result = ds.LoadFromDataFile(filePath);

                // Вывод результата
                Console.WriteLine("                               РЕЗУЛЬТАТ:                                  ");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
