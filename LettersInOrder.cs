// Written by Aicha Maiga 
// 02/19/2025


using System;
using System.Collections.Generic;

namespace HW4IsInOrderorNot
{
    public class LettersInOrder
    {
        public bool ISinOrder(string word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] < word[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
