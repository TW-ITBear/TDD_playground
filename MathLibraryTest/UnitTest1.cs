using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace MathLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Calculate cl = new Calculate();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 3;
 
            //Act
            int actual;
            actual = cl.Add(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod]
        public void MinusTest()
        {
            //Arrange
            Calculate cl = new Calculate();
            int firstNumber = 3;
            int secondNumber = 2;
            int expect = 1;

            //Act
            int actual;
            actual = cl.Minus(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expect, actual);
        }


    }
}
