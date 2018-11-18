using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlphabetWarAirStrike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetWarAirStrike.Tests
{
    [TestClass()]
    public class AlphabetWarTests
    {
        [TestMethod()]
        public void DropBombsTest()
        {
            Assert.AreEqual("Right side wins!", AlphabetWar.DropBombs("z"));
        }
        [TestMethod()]
        public void DropBombsTest2()
        {
            Assert.AreEqual("Let's fight again!", AlphabetWar.DropBombs("z*dq*mw*pb*s"));
        }
        [TestMethod()]
        public void DropBombsTest3()
        {
            Assert.AreEqual("Left side wins!", AlphabetWar.DropBombs("*wwwwww*z*"));
        }
        [TestMethod()]
        public void DropBombsTest4()
        {
            Assert.AreEqual("Let's fight again!", AlphabetWar.DropBombs("zdqmwpbs"));
        }
    }
}