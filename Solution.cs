//written by Aicha Maiga
//04/23/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingZeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int nonzeroes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonzeroes] = nums[i];
                    nonzeroes++;
                       
                }
            }

            for (int i = nonzeroes; i < nums.Length; i++)
            {
                nums[i]= 0;
            }

        }

    }
}
