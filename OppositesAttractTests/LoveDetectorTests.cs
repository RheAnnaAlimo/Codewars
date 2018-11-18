using Microsoft.VisualStudio.TestTools.UnitTesting;
using OppositesAttract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppositesAttract.Tests
{
    [TestClass()]
    public class LoveDetectorTests
    {
        [TestMethod()]
        public void lovefuncTest()
        {
            Assert.AreEqual(true, LoveDetector.lovefunc(1, 4));
        }
        [TestMethod()]
        public void lovefuncTest2()
        {
            Assert.AreEqual(false, LoveDetector.lovefunc(0, 0));
        }
        [TestMethod()]
        public void lovefuncTest3()
        {
            Assert.AreEqual(false, LoveDetector.lovefunc(5, 5));
        }
        [TestMethod()]
        public void lovefuncTest4()
        {
            Assert.AreEqual(false, LoveDetector.lovefunc(2, 2));
        }
    }
}