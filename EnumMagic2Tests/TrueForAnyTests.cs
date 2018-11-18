using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnumMagic2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumMagic2.Tests
{
    [TestClass()]
    public class TrueForAnyTests
    {
        [TestMethod()]
        public void AnyTest1()
        {
            Assert.AreEqual(true, TrueForAny.Any(new int[] { 1, 2, 3, 4 }, v => v > 3));
        }
        [TestMethod()]
        public void AnyTest2()
        {
            Assert.AreEqual(false, TrueForAny.Any(new int[] { 1, 2, 3, 4 }, v => v > 4));
        }
    }
}