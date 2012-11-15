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

        internal void addAuthor(string expectedAuthor)
        {
            if (Authors.Contains(expectedAuthor) == false)
                Authors.Add(expectedAuthor);
        }

        internal void addKeyword(string expectedKeyword)
        {
            if (Keywords.Contains(expectedKeyword) == false)
                Keywords.Add(expectedKeyword);
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
            Title = expectedTitle;
        }

        internal void setYear(int expectedYear)
        {
            Year = expectedYear;
        }
    }
}
