//written by Aicha Maiga
//04/23/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9ReverseString
{
    public class ReverseString
    {
        public void ReverseWord(char[] s)
        {
            int left = 0;
            int right = s.Length-1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }



        }
    }
}
