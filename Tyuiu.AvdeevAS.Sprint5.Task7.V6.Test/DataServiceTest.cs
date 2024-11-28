using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task7.V6.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestLoadDataAndSave()
    {
        DataService ds = new DataService();
        string tempInputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V6.txt");
        string tempOutputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V6.txt");

        // Создаем тестовый входной файл
        File.WriteAllText(tempInputPath, "Hello World! Привет мир!");

        // Выполняем замену и сохранение
        string outputPath = ds.LoadDataAndSave(tempInputPath);

        // Проверяем, что путь к файлу правильный
        Assert.AreEqual(tempOutputPath, outputPath);

        // Проверяем содержимое выходного файла
        string expectedContent = "##### #####! Привет мир!";
        string actualContent = File.ReadAllText(outputPath);

        Assert.AreEqual(expectedContent, actualContent);
    }
}
