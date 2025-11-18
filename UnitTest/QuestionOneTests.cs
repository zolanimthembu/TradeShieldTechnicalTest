using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest;

namespace UnitTest
{
    [TestClass]
    public class QuestionOneTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            string s = "We test coders. Give us a try?";
            Assert.AreEqual(4, QuestionOne.GetLongestSentance(s));
        }
        [TestMethod]
        public void ProvidedExtraTest()
        {
            string s = "Forget CVs..Save time . x x";
            Assert.AreEqual(2, QuestionOne.GetLongestSentance(s));
        }

        [TestMethod]
        public void EmptyAndNoWords()
        {
            Assert.AreEqual(0, QuestionOne.GetLongestSentance(""));
            Assert.AreEqual(0, QuestionOne.GetLongestSentance("...!!!"));
        }
    }
}
