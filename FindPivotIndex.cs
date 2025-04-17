//writtem by Aicha Maiga 
// 04/16/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8PivotIndex
{
    public class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            int total = nums.Sum();
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int rightSum = total - leftSum - nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }

            return -1;
        }
    }
}
