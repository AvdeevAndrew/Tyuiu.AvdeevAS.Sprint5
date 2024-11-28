using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvdeevAS.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Вычисляем значение функции
            double result = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            result = Math.Round(result, 3); // Округляем до 3 знаков

            // Сохраняем результат в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            return path;
        }
    }
}
