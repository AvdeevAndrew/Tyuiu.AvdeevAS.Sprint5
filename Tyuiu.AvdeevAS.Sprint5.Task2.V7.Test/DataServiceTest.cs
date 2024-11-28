using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AvdeevAS.Sprint5.Task2.V7.Lib;
using System.IO;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        DataService ds = new DataService();
        int[,] matrix =
        {
            { 9, 2, 8 },
            { 7, 1, 2 },
            { 5, 5, 1 }
        };

        string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

        string filePath = ds.SaveToFileTextData(matrix);

        Assert.AreEqual(expectedPath, filePath); // Проверяем путь к файлу
        Assert.IsTrue(File.Exists(filePath)); // Проверяем, что файл существует

        // Проверяем содержимое файла
        string[] lines = File.ReadAllLines(filePath);
        Assert.AreEqual("0;2;8", lines[0]);
        Assert.AreEqual("0;0;2", lines[1]);
        Assert.AreEqual("0;0;0", lines[2]);
    }
}
