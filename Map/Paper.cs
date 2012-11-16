using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{

    class Paper
    {
        private string Abstract;
        private List<string> Authors;
        private List<string> Keywords;
        private string Title;
        private int Year;
		
		public Paper()
		{
			// set all values to null, and allocate space for Authors and Keywords
			Abstract = null;
			Authors = new List<string>();
			Keywords = new List<string>();
			Title = null;
			Year = -1;
		}
		
		public Paper(string newAbstract, string newAuthor, string newKeyword, string newTitle, int newYear)
		{
			// verify that arguments are correct
			if (newAbstract == null) throw new ArgumentNullException();
			if (newAbstract == "") throw new ArgumentException();
			if (newAuthor == null) throw new ArgumentNullException();
			if (newAuthor == "") throw new ArgumentException();
			if (newKeyword == null) throw new ArgumentNullException();
			if (newKeyword == "") throw new ArgumentException();
			if (newTitle == null) throw new ArgumentNullException();
			if (newTitle == "") throw new ArgumentException();
			if (newYear < 0) throw new ArgumentException();
			
			// set all values to arguments and allocate space for Authors and Keywords 
			Abstract = newAbstract;
			Authors = new List<string>();
			Authors.Add(newAuthor);
			Keywords = new List<string>();
			Keywords.Add(newKeyword);
			Title = newTitle;
			Year = newYear;
		}
		
		public Paper(string newAbstract, List<string> newAuthors, string newKeyword, string newTitle, int newYear)
		{
			// verify that arguments are correct
			if (newAbstract == null) throw new ArgumentNullException();
			if (newAbstract == "") throw new ArgumentException();
			if (newAuthors == null) throw new ArgumentNullException();
			if (newKeyword == null) throw new ArgumentNullException();
			if (newKeyword == "") throw new ArgumentException();
			if (newTitle == null) throw new ArgumentNullException();
			if (newTitle == "") throw new ArgumentException();
			if (newYear < 0) throw new ArgumentException();
		
			// set all values to arguments and allocate space for Keywords 
			Abstract = newAbstract;
			Authors = newAuthors;
			Keywords = new List<string>();
			Keywords.Add(newKeyword);
			Title = newTitle;
			Year = newYear;
		}
		
		public Paper(string newAbstract, string newAuthor, List<string> newKeywords, string newTitle, int newYear)
		{
			// verify that arguments are correct
			if (newAbstract == null) throw new ArgumentNullException();
			if (newAbstract == "") throw new ArgumentException();
			if (newAuthor == null) throw new ArgumentNullException();
			if (newAuthor == "") throw new ArgumentException();
			if (newKeywords == null) throw new ArgumentNullException();
			if (newTitle == null) throw new ArgumentNullException();
			if (newTitle == "") throw new ArgumentException();
			if (newYear < 0) throw new ArgumentException();
			
			// set all values to arguments and allocate space for Authors and Keywords 
			Abstract = newAbstract;
			Authors = new List<string>();
			Authors.Add(newAuthor);
			Keywords = newKeywords;
			Title = newTitle;
			Year = newYear;
		}
		
		public Paper(string newAbstract, List<string> newAuthors, List<string> newKeywords, string newTitle, int newYear)
		{
			// verify that arguments are correct
			if (newAbstract == null) throw new ArgumentNullException();
			if (newAbstract == "") throw new ArgumentException();
			if (newAuthors == null) throw new ArgumentNullException();
			if (newKeywords == null) throw new ArgumentNullException();
			if (newTitle == null) throw new ArgumentNullException();
			if (newTitle == "") throw new ArgumentException();
			if (newYear < 0) throw new ArgumentException();
		
			// set all values to arguments
			Abstract = newAbstract;
			Authors = newAuthors;
			Keywords = newKeywords;
			Title = newTitle;
			Year = newYear;
		}
		
		~Paper()  // destructor
		{
			// clear contents of paper
			this.clearPaper();	// unsure if correct syntax; I'd appreciate it if someone could verify this for me	-Ryan
		}

        internal void addAuthor(string expectedAuthor)
        {
			if (expectedAuthor == null) throw new ArgumentNullException();
			if (expcetedAuthor == "") throw new ArgumentException();
			
            if (Authors.Contains(expectedAuthor) == false)
                Authors.Add(expectedAuthor);
        }

        internal void addKeyword(string expectedKeyword)
        {
			if (expectedKeyword == null) throw new ArgumentNullException();
			if (expcetedKeyword == "") throw new ArgumentException();
			
            if (Keywords.Contains(expectedKeyword) == false)
                Keywords.Add(expectedKeyword);
        }
		
		internal void clearPaper()
		{
			Abstract = null;
			Authors = null;	// TODO: ensure that the memory is cleared; I doubt this does it	-Ryan
			Keywords = null;	//	see above
			Title = null;
			Year = -1;
		}

        internal void deleteAbstract()
        {
            Abstract = null;
        }

        internal void deleteAuthor(string expectedAuthor)
        {
            Authors.Remove(expectedAuthor);
        }

        internal void deleteAuthors()
        {
            Authors.Clear();
        }

        internal void deleteKeyword(string expectedKeyword)
        {
            Keywords.Remove(expectedKeyword);
        }

        internal void deleteKeywords()
        {
            Keywords.Clear();
        }

        internal void deleteTitle()
        {
            Title = null;
        }

        internal void deleteYear()
        {
            Year = -1;
        }

        internal string getAbstract()
        {
            return Abstract;
        }

        //  please use listAuthors() instead; this accounts for multiple authors
        //                          -Ryan
        internal String getAuthor()
        {
            throw new NotImplementedException();
        }

        internal String getTitle()
        {
            return Title;
        }

        internal int getYear()
        {
            return Year;
        }

        internal List<string> listAuthors()
        {
            return Authors;
        }

        internal List<string> listKeywords()
        {
            return Keywords;
        }

        //  I'd prefer we be consistent with the namings.  As such, please let me know if we're using "remove" or "delete" for deletion prefixes.
        //                                  -Ryan
        internal void removeKeyword(string expectedKeyword)
        {
            Keywords.Remove(expectedKeyword);
        }

        internal void setAbstract(string expectedAbstract)
        {
			if (expectedAbstract == null) throw new ArgumentNullException();
			if (expcetedAbstract == "") throw new ArgumentException();
			
            Abstract = expectedAbstract;
        }

        //  please use addAuthor() and deleteAuthor() instead; this accounts for multiple authors
        //                          -Ryan
        internal void setAuthor(string expectedAuthor)
        {
            throw new NotImplementedException();
        }

        internal void setTitle(string expectedTitle)
        {
			if (expectedTitle == null) throw new ArgumentNullException();
			if (expcetedTitle == "") throw new ArgumentException();
			
            Title = expectedTitle;
        }

        internal void setYear(int expectedYear)
        {
			if (expcetedYear < 0) throw new ArgumentException();
			
            Year = expectedYear;
        }
    }
}
