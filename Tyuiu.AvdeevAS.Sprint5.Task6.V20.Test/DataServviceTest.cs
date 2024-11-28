using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AvdeevAS.Sprint5.Task6.V20.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestLoadFromDataFile()
    {
        DataService ds = new DataService();
        string tempPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V20.txt");

        // Ñמחהאול עוסעמגûי פאיכ
       

        int result = ds.LoadFromDataFile(tempPath);

 
        int expectedCount = 2; 

        Assert.AreEqual(expectedCount, result);
    }
}
