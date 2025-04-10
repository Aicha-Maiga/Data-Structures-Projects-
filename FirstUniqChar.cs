// written by Aicha Maiga
// 04/09/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7FirstUniqChar
{
    public class FirstUniqChar
    {
        public int FirstCharacter(string s)
        {
            int[] freq = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                freq[(int)s[i] - 97]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[(int)s[i] - 97] == 1)
                {
                    return i;
                }

            }
            return -1;

        }



    }
}
