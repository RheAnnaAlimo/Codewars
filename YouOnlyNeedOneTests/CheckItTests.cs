using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouOnlyNeedOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouOnlyNeedOne.Tests
{
    [TestClass()]
    public class CheckItTests
    {
        [TestMethod()]
        public void CheckTest()
        {
            Assert.AreEqual(true, CheckIt.Check(new object[] { 66, 101 }, 66));
        }
        [TestMethod()]
        public void CheckTest2()
        {
            Assert.AreEqual(true, CheckIt.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
        }
        [TestMethod()]
        public void CheckTest3()
        {
            Assert.AreEqual(true, CheckIt.Check(new object[] { "anyone", "want", "to", "hire", "me?" }, "me?"));
        }
    }
}