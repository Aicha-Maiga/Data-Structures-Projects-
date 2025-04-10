// written by Aicha Maiga
//04/09/2025




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7FindtheDifference
{
    public class Difference
    {
        public char LetterAdded(string s, string t)
        {
            // using ASCII Table

            int sumS = 0;
            int sumT = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sumS += s[i];
            }

            for (int i = 0; i < t.Length; i++)
            {
                sumT += t[i];
            }

            return (char)(sumT - sumS);
        }
    }
}
