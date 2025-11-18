using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            int maxWords = 0;
            var letterRegex = new Regex("[A-Za-z]");

            foreach (var raw in sentences)
            {
                var tokens = raw.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                int words = tokens.Count(t => letterRegex.IsMatch(t));
                if (words > maxWords) maxWords = words;
            }

            return maxWords;
        }
    }
}
