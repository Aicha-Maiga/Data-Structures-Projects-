// Written by Aicha Maiga 
// 02/19/2025


using System;
using System.Collections.Generic;

namespace HW4ChangingLetters
{
    public class ChangingLetters
    {
        public string ChangetoNext(string word)
        {
            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                char nextletter = (char)(word[i] + 1); 
                result += nextletter;
            }

            return result;
        }
    }
}
