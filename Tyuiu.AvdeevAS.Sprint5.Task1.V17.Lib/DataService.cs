using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvdeevAS.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using (StreamWriter writer = new StreamWriter(path))
            {
                
                for (int x = startValue; x <= stopValue; x++)
                {
                    double fx;
                    try
                    {
                        double denominator = Math.Sin(x) + 1;
                        if (Math.Abs(denominator) < 1e-10) // Проверка деления на ноль
                        {
                            fx = 0; // Если деление на ноль, устанавливаем значение 0
                        }
                        else
                        {
                            fx = 2 * x - 4 + (2 * x - 1) / denominator;
                        }
                    }
                    catch
                    {
                        fx = 0; // Любые другие ошибки также приводят к значению 0
                    }
                    writer.WriteLine($"{Math.Round(fx, 2)}");
                }
            }
            return path;
        }
    }
}
