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

        public Paper()
        {
            authors = new List<string>();
            keywords = new List<string>();
        }

        public void addKeyword(string p)
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

        public List<string> getListKeywords()
        {
            return keywords;
        }

        public void setTitle(string expectedtitle)
        {
            title = expectedtitle;
        }
        
        public void setAuthor(string expectedauthor)
        {
            authors.Add(expectedauthor);
        }

        public void setYear(int expectedyear)
        {
            year = expectedyear;
        }

        public void setAbstract(string expectedabstract)
        {
            paperabstract = expectedabstract;
        }

        public String getTitle()
        {
            return title;
        }

        public List<string> getAuthor()
        {
            return authors;
        }

        public int getYear()
        {
            return year;
        }

        public string getAbstract()
        {
            return paperabstract;
        }
    }
}
