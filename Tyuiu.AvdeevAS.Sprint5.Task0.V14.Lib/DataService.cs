using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvdeevAS.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {

        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            if (x * x * x - 1 == 0)
                throw new DivideByZeroException("Деление на ноль в знаменателе.");
            double y = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            File.WriteAllText(path, Convert.ToString(Math.Round(y, 3))); // Округляем до 3 знаков
            return path;
        }
    }
}
