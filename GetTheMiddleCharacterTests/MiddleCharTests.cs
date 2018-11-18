using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetTheMiddleCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheMiddleCharacter.Tests
{
    [TestClass()]
    public class MiddleCharTests
    {
        [TestMethod()]
        public void GetMiddleTest()
        {
            Assert.AreEqual("es", MiddleChar.GetMiddle("test"));
        }

        [TestMethod()]
        public void GetMiddleTest2()
        {
            Assert.AreEqual("t", MiddleChar.GetMiddle("testing"));
        }
        
        [TestMethod()]
        public void GetMiddleTest3()
        {
            Assert.AreEqual("A", MiddleChar.GetMiddle("A"));
        }
    }
}