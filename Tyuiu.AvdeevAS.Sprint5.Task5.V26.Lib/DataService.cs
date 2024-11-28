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

            string[] lines = File.ReadAllLines(path); // Чтение строк из файла

            double positiveSum = 0;
            double negativeSum = 0;

            foreach (string line in lines)
            {
                if (double.TryParse(line.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                {
                    value = Math.Round(value, 3); // Округляем до 3 знаков
                    if (value > 0)
                    {
                        positiveSum += value;
                    }
                    else
                    {
                        negativeSum += value;
                    }
                }
            }

            double result = positiveSum - Math.Abs(negativeSum); // Разница между суммами
            return Math.Round(result, 3); // Округляем результат до 3 знаков
        }
    }
}
