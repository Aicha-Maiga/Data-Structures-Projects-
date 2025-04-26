// written by Aicha Maiga
// 04/23/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9HappyNumber
{
    public class HappyNumber
    {
        private int GetSumOfSquares(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }

            return sum;
        }

        public bool IsHappy(int n)
        {
            List<int> seen = new List<int>();

            while (n != 1)
            {
                if (seen.Contains(n))
                {
                    return false; 
                }

                seen.Add(n);
                n = GetSumOfSquares(n);
            }

            return true; 
        }



    }
}
