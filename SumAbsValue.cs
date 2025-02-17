// Written by Aicha Maiga 
// 02/12/2025


using System;
using System.Collections.Generic;


namespace SumofAbsoluevalue
{
    public class SumAbsValue
    {
        public int GetSumAbs(int[] numbers)
        {
            int sum = 0;
            int absvalue = 0;

            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    absvalue = -num;
                }
                else
                {
                    absvalue = num;
                }

                sum += absvalue;
            }

            return sum;
        }
    }
}

