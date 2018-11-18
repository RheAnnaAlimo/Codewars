using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMathOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathOp.Tests
{
    [TestClass()]
    public class OperationsTests
    {
        [TestMethod()]
        public void basicOpTest()
        {
            Assert.AreEqual(Operations.basicOp('+', 4, 7), 11);
        }
        [TestMethod()]
        public void basicOpTest2()
        {
            Assert.AreEqual(Operations.basicOp('-', 15, 18), -3);
        }
        [TestMethod()]
        public void basicOpTest3()
        {
            Assert.AreEqual(Operations.basicOp('*', 5, 5), 25);
        }
        [TestMethod()]
        public void basicOpTest4()
        {
            Assert.AreEqual(Operations.basicOp('/', 49, 7), 7);
        }
    }
}