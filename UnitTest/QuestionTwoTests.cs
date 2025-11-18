using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest;

namespace UnitTest
{
    [TestClass]
    public class QuestionTwoTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            int[] a = { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 };
            Assert.AreEqual(4, QuestionTwo.GetPitDepth(a));
        }
        [TestMethod]
        public void ProvidedExtraTest()
        {
            int[] a = { 1, 2, 3, 1, 2, 3, 1, 2, 3 };
            Assert.AreEqual(2, QuestionTwo.GetPitDepth(a));
        }

        [TestMethod]
        public void NoPits_ReturnsMinusOne()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(-1, QuestionTwo.GetPitDepth(a));
        }
    }
}
