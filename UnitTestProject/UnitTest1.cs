using DoggyRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form = new Form1();
        [TestMethod]
        public void TestMethod1()
        {
            Guy[] guys = new Guy[3];
            guys.ToString().Equals("3");

        }
    }
}
