using System;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task3.V24.Lib;

namespace Tyuiu.AvdeevAS.Sprint5.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #5                              *");
            Console.WriteLine("* Тема: Вычисление функции и запись в файл                                *");
            Console.WriteLine("*                              Задание #3                                 *");
            Console.WriteLine("*                              Вариант #24                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");

            // Исходные данные
            int x = 3;
            Console.WriteLine("                               ИСХОДНЫЕ ДАННЫЕ                             ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"x = {x}");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Сохранение результата
                Console.WriteLine("                               РЕЗУЛЬТАТ:                                  ");
                Console.WriteLine("***************************************************************************");
                string filePath = ds.SaveToFileTextData(x);

                Console.WriteLine($"Файл: {filePath}");

                // Читаем содержимое бинарного файла
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    double result = reader.ReadDouble();
                    Console.WriteLine($"Результат: {result}");
                }

                Console.WriteLine("Файл успешно создан!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
