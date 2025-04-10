// written by Aicha Maiga
// 04/09/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7MergeStrings
{
    public class MergingStrings
    {
        public string MergedString(string word1, string word2)
        {
            string result = "";

            int i = 0;
            int j = 0;

            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length)
                {
                    result += word1[i];
                    i++;
                }

                if (j < word2.Length)
                {
                    result += word2[j];
                    j++;
                }
            }

            return result;
        }
    }
}
