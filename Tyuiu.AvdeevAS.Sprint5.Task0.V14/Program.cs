using System;
using Tyuiu.AvdeevAS.Sprint5.Task0.V14.Lib;

namespace Tyuiu.AvdeevAS.Sprint5.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #5                              *");
            Console.WriteLine("* Тема: <...>                                                             *");
            Console.WriteLine("*                              Задание #0                                 *");
            Console.WriteLine("*                              Вариант #14                                *");
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
                string res = ds.SaveToFileTextData(x);

                Console.WriteLine($"Файл: {res}");
                Console.WriteLine("Содержимое файла: " + System.IO.File.ReadAllText(res));
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
