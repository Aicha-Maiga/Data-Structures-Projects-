// written by Aicha Maiga
// 04/09/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7MaxNumBalloons
{
    public class MaxNumBalloons
    {
        public int MaxNumofInstances(string text)
        {
            int[] count = new int[26];

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                count[c - 'a']++;

            }

            int b = count['b' - 'a'];
            int a = count['a' - 'a'];
            int l = count['l' - 'a'] / 2;
            int o = count['o' - 'a'] / 2;
            int n = count['n' - 'a'];

            int min = b;
            if (a < min) min = a;
            if (l < min) min = l;
            if (o < min) min = o;
            if (n < min) min = n;

            return min;



        }
    }
}
