// written by Aicha Maiga
// 04/09/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7NumOfSegments
{
    public class NumberSegment
    {
        public int CountSegment(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && (i == 0 || s[i - 1] == ' '))
                {
                    count++;
                }
            }
            return count;

        }
    }
}
