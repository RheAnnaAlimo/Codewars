using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAndStar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndStar.Tests
{
    [TestClass()]
    public class SortingArrayTests
    {
        [TestMethod()]
        public void TwoSortTest()
        {
            Assert.AreEqual("b***i***t***c***o***i***n", SortingArray.TwoSort(new[] { "bitcoin", "take", "over", "the", "world" }));
        }

        [TestMethod()]
        public void TwoSortTest2()
        {
            Assert.AreEqual("c***o***d***e", SortingArray.TwoSort(new[] { "i", "want", "to", "travel", "the", "world", "writing", "code" }));
        }
        [TestMethod()]
        public void TwoSortTest3()
        {
            Assert.AreEqual("L***e***t***s", SortingArray.TwoSort(new[] { "Lets", "all", "go", "on", "holiday" }));
        }
    }
}