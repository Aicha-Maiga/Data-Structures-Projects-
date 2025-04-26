//written by Aicha Maiga
//04/23/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9MajorityElement
{
    public class MajorityElement
    {
        public int FindMajority(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            int majorityCount = nums.Length / 2;

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (!counts.ContainsKey(num))
                    counts[num] = 1;
                else
                    counts[num]++;


                if (counts[num] > majorityCount)
                    return num;
            }

            return -1; 
        }
    }
}
