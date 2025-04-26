//written by Aicha Maiga
//04/23/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9LenghofLastWord
{
    public class LastWord
    {
        public int FindLength(string s)
        {
            int length = 0;
            int i= s.Length-1;

            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }
            return length;

        }
    }
}
