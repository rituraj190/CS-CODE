using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectSI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimpleInterest sitest = new SimpleInterest();
            float sit = sitest.getsi(100,2);
            Assert.AreEqual(sit,24);
        }
    }
}
