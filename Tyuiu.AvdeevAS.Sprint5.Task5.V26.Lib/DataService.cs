using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvdeevAS.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл по пути {path} не найден.");
            }

            // Считываем весь текст из файла и разделяем его по пробелам
            string fileContent = File.ReadAllText(path);
            string[] values = fileContent.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double positiveSum = 0;
            double negativeSum = 0;

            foreach (string value in values)
            {
                // Парсим значение с использованием InvariantCulture
                if (double.TryParse(value.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                {
                    number = Math.Round(number, 3); // Округляем до 3 знаков
                    if (number > 0)
                    {
                        positiveSum += number;
                    }
                    else
                    {
                        negativeSum += number;
                    }
                }
            }

            double result = positiveSum - Math.Abs(negativeSum); // Разница между суммами
            return Math.Round(result, 3); // Округляем результат до 3 знаков
        }
    }
}
