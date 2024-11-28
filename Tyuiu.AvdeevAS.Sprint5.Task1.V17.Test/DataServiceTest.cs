using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task1.V17.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        DataService ds = new DataService();
        string expectedFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

        string filePath = ds.SaveToFileTextData(-5, 5);

        Assert.AreEqual(expectedFilePath, filePath); // ��������� ���� � �����
        Assert.IsTrue(File.Exists(filePath)); // ���������, ��� ���� ����������

        // ��������� ���������� �����
        string[] lines = File.ReadAllLines(filePath);
        Assert.AreEqual("x\tF(x)", lines[0]); // ������ ������ - ���������
        Assert.AreEqual(12, lines.Length); // ���������, ��� ����� 11 (�� -5 �� 5 ������������)
    }
}
