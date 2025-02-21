// Written by Aicha Maiga 
// 02/19/2025

using System;
using System.Collections.Generic;


namespace HW4WordCount
{
    public class WordCount
    {
        public int FindWordCount(string sentence)
        {
            string [] words = sentence.Split(' ');

            int wordcount = words.Length;
            return wordcount;
        }
    }
}
