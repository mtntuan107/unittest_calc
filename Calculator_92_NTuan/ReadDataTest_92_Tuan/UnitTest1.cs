using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator_92_NTuan;
namespace ReadDataTest_92_Tuan
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        public TestContext TestContext { get; set; }
        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\DataTest.csv", "DataTest#csv", DataAccessMethod.Sequential)]
        [TestMethod] //data
        public void Test_Data_92_Tuan()
        {           
            int a, b, ex, ac;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            ex = int.Parse(TestContext.DataRow[2].ToString());
            c = new Calculation(a, b);
            ac = c.Execute("+");
            Assert.AreEqual(ex, ac);
        }
    }
}
