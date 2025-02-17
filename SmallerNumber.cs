// Written by Aicha
// 02/12/2024


using System;
using System.Collections.Generic;


namespace Smallernumber
{
    public class SmallerNumber
    {
        public string SmallerNum(string num1, string num2)
        {
            if (num1.Length < num2.Length)
            {
                return num1;
            }
            else if (num1.Length > num2.Length)
            {
                return num2;
            }
            else
            {
                for (int i = 0; i < num1.Length; i++)
                {
                    if (num1[i] < num2[i])
                    {
                        return num1;
                    }
                    else if (num1[i] > num2[i])
                    {
                        return num2;
                    }
                }
                return num1;
            }
        }
    }
}
