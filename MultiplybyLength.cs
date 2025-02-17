// Written by Aicha Maiga 
// 02/12/2025

using System;
using System.Collections.Generic;


namespace Multiplyby
{
    public class MultiplybyLength
    {
        public int[] MultiplyByLength(int[] numbers)
        {
            int length = numbers.Length;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = numbers[i] * length;
            }

            return result;
        }
    }

}

