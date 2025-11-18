using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] A)
        {
            if (A == null || A.Length < 3) return -1;

            int n = A.Length;
            int i = 0;
            int maxDepth = -1;

            while (i < n - 1)
            {
                while (i < n - 1 && A[i] <= A[i + 1]) i++;
                int P = i;

                while (i < n - 1 && A[i] > A[i + 1]) i++;
                int Q = i;

                if (P == Q || Q == n - 1)
                {
                    continue;
                }

                while (i < n - 1 && A[i] < A[i + 1]) i++;
                int R = i;

                if (P < Q && Q < R)
                {
                    if (A[P] > 0)
                    {
                        long leftDepth = (long)A[P] - (long)A[Q];
                        long rightDepth = (long)A[R] - (long)A[Q];
                        long depth = Math.Min(leftDepth, rightDepth);
                        if (depth > maxDepth) maxDepth = (int)depth;
                    }
                }

            }

            return maxDepth;
        }
    }
}
