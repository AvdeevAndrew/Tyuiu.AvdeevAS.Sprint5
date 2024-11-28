using System;
using System.Globalization;
using System.IO;
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

            string fileContent = File.ReadAllText(path);
            string[] values = fileContent.Split(new[] { ' ', '\n', '\r', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);

            double positiveSum = 0;
            double negativeSum = 0;

            foreach (string value in values)
            {
                string sanitizedValue = value.Replace(",", ".").Trim(); // Обрабатываем числа с запятыми
                if (double.TryParse(sanitizedValue, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                {
                    if (number > 0)
                    {
                        positiveSum += number; // Округляем каждое положительное число
                    }
                    else if (number < 0 && sanitizedValue.Contains(".")) // Условие: число отрицательное и дробное
                    {
                        negativeSum += number; // Суммируем только отрицательные вещественные числа
                    }
                }
            }

            double result = positiveSum - Math.Abs(negativeSum); // Разница между положительными и отрицательными
            return Math.Round(result, 3); // Округляем до 3 знаков
        }
    }
}
