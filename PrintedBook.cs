// written by Aicha Maiga
// 02/27/2025


using System;
using System.Collections.Generic;


namespace HW5LibrarySystems
{
    public class PrintedBook: Book
    {
        // variables
        private int pageCount =-1;

        // gets and sets
        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount = value; }
        }

        // constructor
        public PrintedBook(string aTitle, string anAuthor, int theYearPublished, int aPageCount): base(aTitle, anAuthor, theYearPublished)
        {
            this.PageCount = aPageCount;
        }

        // method
        public override string ToString()
        {

            return base.ToString() + $", Pages: {PageCount}";
        }
    }
}
