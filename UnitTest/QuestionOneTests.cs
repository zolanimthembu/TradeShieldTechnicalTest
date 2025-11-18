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
    }
}
