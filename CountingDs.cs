// Written by Aicha Maiga
// 02/12/2025

using System;
using System.Collections.Generic;

namespace CountingD
{
    public class CountingDs
    {
        public int CountDs(string sentence)
        {
            int count = 0;

            foreach (char c in sentence)
            {
                if (c == 'D' || c == 'd')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
