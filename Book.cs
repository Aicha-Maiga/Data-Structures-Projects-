// written by Aicha Maiga
// 02/27/2025


using System;
using System.Collections.Generic;

namespace HW5LibrarySystems
{
    public class Book
    {
        // variables
        private string title= "n/a";
        private string author = "n/a";
        private int yearPublished = -1;

        // gets and sets
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        // constructor
        public Book(string aTitle, string anAuthor, int theYearPublished)
        {
            this.Title = aTitle;
            this.Author = anAuthor;
            this.YearPublished = theYearPublished;
        }

        // method
        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished})";
        }
    }
}
