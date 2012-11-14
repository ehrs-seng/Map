using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class Paper
    {

        string title;
        List<string> authors;
        int year;
        List<string> keywords;
        string paperabstract;

        internal void addKeyword(string p)
        {
            if (keywords.Contains(p))
            {
                throw new ArgumentException("No duplicate keywords allowed.");
            }
            else if (p == "")
            {
                throw new ArgumentException("Keywords must not be an empty string");
            }
            else if(System.Text.RegularExpressions.Regex.IsMatch(p, "^[a-z]*^[A-Z]"))
            {
                throw new ArgumentException("Keywords must contain letters");
            }
            else if(p == null)
            {
                throw new ArgumentNullException("Keywords must not be a null value");
            }
            //testing commit by adding this random useless comment... Ed.
            keywords.Add(p);
        }

        internal List<string> getListKeywords()
        {
            return keywords;
        }

        internal void setTitle(string expectedtitle)
        {
            title = expectedtitle;
        }
        
        internal void setAuthor(string expectedauthor)
        {
            authors.Add(expectedauthor);
        }

        internal void setYear(int expectedyear)
        {
            year = expectedyear;
        }

        internal void setAbstract(string expectedabstract)
        {
            paperabstract = expectedabstract;
        }

        internal String getTitle()
        {
            return title;
        }

        internal List<string> getAuthor()
        {
            return authors;
        }

        internal int getYear()
        {
            return year;
        }

        internal string getAbstract()
        {
            return paperabstract;
        }
    }
}
