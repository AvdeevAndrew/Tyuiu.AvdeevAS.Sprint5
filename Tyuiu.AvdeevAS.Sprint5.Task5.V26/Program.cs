using System;
using System.Globalization;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task5.V26.Lib;

namespace Tyuiu.AvdeevAS.Sprint5.Task5.V26
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
            Console.WriteLine("*                              Задание #5                                 *");
            Console.WriteLine("*                              Вариант #26                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");

            // Путь к файлу
            string directory = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask5V26.txt";
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
                Console.WriteLine($"Разница между суммами положительных и отрицательных чисел: {result.ToString("F3", CultureInfo.InvariantCulture)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
