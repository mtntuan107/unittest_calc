using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator_92_NTuan;

namespace CalculatorTester_92_NTuan
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;       
        [TestInitialize]
        public void SetUp()
        {
            c = new Calculation(6, 3);
        }
        [TestMethod] // TC1: a = 6, b= 3, kq = 9
        public void Test_Cong_92_NTuan()
        {
            int ex, ac;
            ex = 9;
            ac = c.Execute("+");
            Assert.AreEqual(ex, ac);
        }
        [TestMethod] // TC2: a = 6, b= 3, kq = 3
        public void Test_Tru_92_NTuan()
        {
            int ex, ac;
            ex = 3;
            ac = c.Execute("-");
            Assert.AreEqual(ex, ac);
        }
        [TestMethod] // TC3: a = 6, b= 3, kq = 18
        public void Test_Nhan_92_NTuan()
        {
            int ex, ac;
            ex = 18;
            ac = c.Execute("*");
            Assert.AreEqual(ex, ac);
        }
        [TestMethod] // TC4: a = 6, b= 3, kq = 2
        public void Test_Chia_92_NTuan()
        {
            int ex, ac;
            ex = 2;
            ac = c.Execute("/");
            Assert.AreEqual(ex, ac);
        }
        [TestMethod] // TC5: Chia cho 0
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_92_NTuan()
        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }

        
    }
}
