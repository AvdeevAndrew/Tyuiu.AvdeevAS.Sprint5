using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvdeevAS.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл по пути {path} не найден.");
            }

            // Чтение значения из файла
            string fileContent = File.ReadAllText(path);

            double x = double.Parse(fileContent.Replace('.', ','));

            // Проверка на деление на ноль
            double denominator = Math.Sin(x);
            

            
            
            // Вычисление значения функции
            double y = (4.26 * x) / denominator;
            return Math.Round(y, 3); // Округление до 3 знаков
        }
    }
}
