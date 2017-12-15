using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateFormula()
        {
            compoundInterest compoundInterestCalc = new compoundInterest();
            float result = compoundInterestCalc.ci(100,2);
            Assert.AreEqual(result, 12100);

        }
    }
}
