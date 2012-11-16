using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    class Paper
    {
        private List<string> keywords;
        internal void addKeyword(string p)
        {
            //testing commit by adding this random useless comment... Ed.
            throw new NotImplementedException();
        }

        internal List<string> listKeywords()
        {
            throw new NotImplementedException();
        }

        internal void removeKeyword(string expectedkeyword)
        {
            throw new NotImplementedException();
        }

        internal void setTitle(string expectedtitle)
        {
            throw new NotImplementedException();
        }
        
        internal void setAuthor(string expectedauthor)
        {
            throw new NotImplementedException();
        }

        internal void setYear(int expectedyear)
        {
            throw new NotImplementedException();
        }

        internal void setAbstract(string expectedabstract)
        {
            throw new NotImplementedException();
        }

        internal void setKeywords(List<string> paperKeywords)
        {

            keywords = new List<String>();

            keywords = paperKeywords;

        }

        internal String getTitle()
        {
            throw new NotImplementedException();
        }

        internal String getAuthor()
        {
            throw new NotImplementedException();
        }

        internal int getYear()
        {
            throw new NotImplementedException();
        }

        internal string getAbstract()
        {
            throw new NotImplementedException();
        }

        internal List<string> getKeywords()
        {

            return keywords;

        }
    }
}
