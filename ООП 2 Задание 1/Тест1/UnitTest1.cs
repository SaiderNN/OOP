using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ООП_2_Задание_1;
namespace Тест1
{
    [TestClass]
    public class NODTests
    {
        [TestMethod]
        public void TestNOD()
        {
            int num1 = 20;
            int num2 = 10;
            int expectedNOD = 10;

            int actualNOD = Form1.NOD(num1, num2);

            Assert.AreEqual(expectedNOD, actualNOD);
        }

        [TestMethod]
        public void TestNODNegativeNumbers()
        {
            int num1 = -20;
            int num2 = -10;
            int expectedNOD = 10;

            Form1 form1 = new Form1();

            int actualNOD = Form1.NOD(num1, num2);

            Assert.AreEqual(expectedNOD, actualNOD);
        }

        [TestMethod]
        public void TestNODZero()
        {
            int num1 = 0;
            int num2 = 5;
            int expectedNOD = 5;

            int actualNOD = Form1.NOD(num1, num2);

            Assert.AreEqual(expectedNOD, actualNOD);
        }
    }
}