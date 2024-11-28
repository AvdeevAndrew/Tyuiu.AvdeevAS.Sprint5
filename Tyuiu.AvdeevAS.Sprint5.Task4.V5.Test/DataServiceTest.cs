using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task4.V5.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestLoadFromDataFile()
    {
        DataService ds = new DataService();
        string tempPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V0.txt");

        // ������� �������� ����
        File.WriteAllText(tempPath, "1.57"); // ������ �������� x (�������)

        double result = ds.LoadFromDataFile(tempPath);

        // ��������� �������� ��� x = 1.57
        Assert.AreEqual(4.26 / 1.0, result, 0.001); // ��������� � ��������� 0.001
    }
}
