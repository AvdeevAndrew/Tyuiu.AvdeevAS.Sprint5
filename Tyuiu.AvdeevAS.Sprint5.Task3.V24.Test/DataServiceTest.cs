using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task3.V24.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        DataService ds = new DataService();
        int x = 3;
        string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

        string filePath = ds.SaveToFileTextData(x);

        Assert.AreEqual(expectedPath, filePath); // ��������� ���� � �����
        Assert.IsTrue(File.Exists(filePath)); // ���������, ��� ���� ����������

        // ��������� ���������� �����
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            double result = reader.ReadDouble();
            Assert.AreEqual(171.891, result); // ��������� ����������� ���������
        }
    }
}
