using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddNumbersTest
{
    [TestClass]
    public class UnitTestAddNumber
    {
        [TestMethod]
        public void TestMethod1()
        {
            //set
            int numb1 = 2;
            int numb2 = 3;
            int ExcpectedSum = 0;
            ExcpectedSum += numb1 + numb2;

            ///act
            var addtwomubers = new Add(numb1, numb2);
            var ActualSum = addtwomubers.AddTwoNumbers();


            //Assert
            Assert.AreEqual(ExcpectedSum, ActualSum);

        }
    }
}
