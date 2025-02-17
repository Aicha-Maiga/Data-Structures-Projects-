//Written by Aicha Maiga 
// 02/12/2025

using System;
using System.Collections.Generic;

namespace HW3Questions
{
    public class MinMax
    {
        public int[] FindMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return new int[] { min, max };

        }
         
    }
}
