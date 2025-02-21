// Written by Aicha Maiga 
// 02/19/2025


using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace HW4FirstandLast
{
    public class FirstLastChar
    {
        public string FindFirstLastChar(string sentence )
        {
            string result = "";

            if (sentence.Length < 2)
            {
                return "Incompatible";
            }
            else if (sentence[0] == sentence[sentence.Length - 1])
            {
                return "Two's a pair.";
            }
            else
            {
                char firstletter = sentence[0];
                char lastletter= sentence[sentence.Length - 1];
                result = lastletter + sentence.Substring(1, sentence.Length - 2) + firstletter;
            }
            return result; 

        }
     }
}
