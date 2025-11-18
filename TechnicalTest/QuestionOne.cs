using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var sentences = s.Split(new[] { '.', '?', '!' }, StringSplitOptions.None);
        }
    }
}
