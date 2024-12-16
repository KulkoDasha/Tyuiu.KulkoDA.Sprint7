using Tyuiu.KulkoDA.Project.V7.Lib;
namespace Tyuiu.KulkoDA.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds =new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\Проект.csv";
            int res = ds.RowCount(path);
            Assert.AreEqual(15, res);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\Проект — копия.csv";
            string[,] res = { { "Kulko", "6", "143", "54", "2","No","0","2" }, { "Kulko", "6", "143", "54", "2", "No", "0", "2" } };
            CollectionAssert.AreEqual(res,ds.StringMass(path));
        }
    }
}