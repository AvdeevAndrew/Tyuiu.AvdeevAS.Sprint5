using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task5.V26.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestLoadFromDataFile()
    {
        DataService ds = new DataService();
        string tempPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V26.txt");

        // Создаем тестовый файл
        File.WriteAllLines(tempPath, new string[] { "1.234", "-2.456", "3.789", "-4.567", "5.678" });

        double result = ds.LoadFromDataFile(tempPath);

        // Ожидаемая разница между суммами
        double expectedPositiveSum = Math.Round(1.234 + 3.789 + 5.678, 3); // Положительные числа
        double expectedNegativeSum = Math.Round(Math.Abs(-2.456 + -4.567), 3); // Отрицательные числа
        double expectedResult = Math.Round(expectedPositiveSum - expectedNegativeSum, 3);

        Assert.AreEqual(expectedResult, result);
    }
}
