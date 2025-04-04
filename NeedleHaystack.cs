// written by Aicha Maiga
// 04/03/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_NeedleHaystack
{ 
    public class NeedleHaystack
    {
            public int FindNeedle(string haystack, string needle)
            {
                int haystackLen = haystack.Length;
                int needleLen = needle.Length;

                if (needleLen > haystackLen)
                    return -1;

                for (int i = 0; i <= haystackLen - needleLen; i++)
                {
                    int j;
                    for (j = 0; j < needleLen; j++)
                    {
                        if (haystack[i + j] != needle[j])
                            break;
                    }

                    if (j == needleLen)
                        return i;
                }

                return -1;
            }
   
    }
}