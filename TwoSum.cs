// written by Aicha Maiga 
// 04/02/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_TwoSum
{
    public class TwoSum
    {
        public int[] FindTwoSum(int[] nums, int target)
        {
            int[] result= new int[nums.Length];
            for (int i= 0; i<nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
    }
}
