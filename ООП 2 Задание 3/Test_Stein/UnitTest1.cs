using Microsoft.VisualStudio.TestTools.UnitTesting;
using ООП_2_Задание_3;

namespace Test_Stein
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindGCDStein_1()
        {
            int expected = 6;
            long time;
            int result = Form1.FindGCDStein(out time, 54, 24);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindGCDStein_2()
        {
            int expected = 0;
            long time;
            int result = Form1.FindGCDStein(out time, 0, 0);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindGCDStein_3()
        {
            int expected = 4;
            long time;
            int result = Form1.FindGCDStein(out time, 298467352, 569484);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindGCDStein_4()
        {
            int expected = 32;
            long time;
            int result = Form1.FindGCDStein(out time, 64, 32, 160, 96);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindGCDStein_5()
        {
            int expected = 45;
            long time;
            int result = Form1.FindGCDStein(out time, 0, 45);
            Assert.AreEqual(expected, result);
        }
    }
}
