// Written by Aicha Maiga 
// 02/19/2025


using System;
using System.Collections.Generic;

namespace HW4NumVowels
{
    public class Vowels
    {
        public string FindNumVowels(string sentence, int n)
        {
            string numofvowels = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' ||
                sentence[i] == 'o' || sentence[i] == 'u' || sentence[i] == 'y' ||
                sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] == 'I' ||
                sentence[i] == 'O' || sentence[i] == 'U' || sentence[i] == 'Y')
                {
                    numofvowels += sentence[i];
                }
            if (numofvowels.Length == n)
            {
                    return numofvowels;
            }
        }

        return "Invalid";
        }
    }
}
