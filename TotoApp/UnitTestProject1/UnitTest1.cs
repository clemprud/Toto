using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TotoApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var calc = new ConverterLibrary();

            //Act
            var result = calc.GetInt("42");

            //Assert
            Assert.AreEqual(42, result);
        }
    }
}
