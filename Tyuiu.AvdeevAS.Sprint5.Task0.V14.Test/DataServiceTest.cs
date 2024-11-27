using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task0.V14.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        DataService ds = new DataService();

        int x = 3;
        string expectedPath = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

        string filePath = ds.SaveToFileTextData(x);

        Assert.AreEqual(expectedPath, filePath); // Проверяем путь к файлу
        Assert.IsTrue(File.Exists(filePath)); // Проверяем, что файл создан
        Assert.AreEqual("4.154", File.ReadAllText(filePath)); // Проверяем содержимое файла
    }
}
