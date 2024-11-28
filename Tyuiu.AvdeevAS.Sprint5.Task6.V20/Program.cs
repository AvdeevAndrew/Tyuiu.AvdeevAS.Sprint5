using System;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task6.V20.Lib;

namespace Tyuiu.AvdeevAS.Sprint5.Task6.V20
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
            Console.WriteLine("*                              Задание #6                                 *");
            Console.WriteLine("*                              Вариант #20                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");

            // Путь к файлу
            string directory = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask6V20.txt";
            string filePath = Path.Combine(directory, fileName);

            Console.WriteLine("                               ИСХОДНЫЕ ДАННЫЕ                             ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Путь к файлу: {filePath}");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Вычисление результата
                int count = ds.LoadFromDataFile(filePath);

                // Вывод результата
                Console.WriteLine("                               РЕЗУЛЬТАТ:                                  ");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"Количество слов длиной 6 символов: {count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
