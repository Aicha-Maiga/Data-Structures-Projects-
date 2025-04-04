// Written by Aicha Maiga 
// 04/03/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_SortbyParity
{
    public class SortByParity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int[] arr = new int[nums.Length];

            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) { j++; }
            }

            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) { arr[k++] = nums[i]; }
                else { arr[j++] = nums[i]; }
            }

            return arr;
        }
    }
}
