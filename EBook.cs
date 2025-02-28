// written by Aicha Maiga
// 02/27/2025

using System;
using System.Collections.Generic;


namespace HW5LibrarySystems
{
    internal class EBook: Book
    {
        // variables
        private double fileSizeMB = 00;

        //gets and sets
        public double FileSizeMB
        {
            get { return this.fileSizeMB; }
            set { this.fileSizeMB = value; }
        }

        //constructor
        public EBook(string aTitle, string anAuthor, int theYearPublished, double theFileSizeMB): base(aTitle, anAuthor, theYearPublished)
        {
            this.FileSizeMB = theFileSizeMB;
        }

        // method
        public override string ToString()
        {
            return base.ToString() + $", File Size: {FileSizeMB:F2} MB";
        }
    }

}
