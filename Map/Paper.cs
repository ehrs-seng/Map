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

        public void setAuthors()
        {
            authors = new List<string>();
        }

        public void setKeywords()
        {
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
            
            else if(!System.Text.RegularExpressions.Regex.IsMatch(p, "[a-z]|[A-Z]"))
            {
                throw new ArgumentException("Keywords must contain letters");
            }
            else if (p == null)
            {
                throw new ArgumentNullException("Keywords must not be a null value");
            }
            else
            {
                keywords.Add(p);
            }
        }

        public void setTitle(string expectedtitle)
        {
            if (expectedtitle == "") { throw new ArgumentException("Title must not be an empty string"); }
            else if(expectedtitle == null){throw new ArgumentNullException("Title must not be a null value");}
            else{title = expectedtitle;}
        }
        
        public void setAuthor(string expectedauthor)
        {
            if (keywords.Contains(expectedauthor))
            {
                throw new ArgumentException("No duplicate authors allowed.");
            }
            else if (expectedauthor == "")
            {
                throw new ArgumentException("Author must not be an empty string");
            }

            /*else if (!System.Text.RegularExpressions.Regex.IsMatch(expectedauthor, "[a-z]|[A-Z]"))
            {
                throw new ArgumentException("Author must contain letters");
            }*/
            else if (expectedauthor == null)
            {
                throw new ArgumentNullException("Author must not be a null value");
            }
            else
            {
                authors.Add(expectedauthor);
            }
        }

        public void setYear(int expectedyear)
        {
            if (expectedyear < 0) { throw new ArgumentOutOfRangeException("Year must not be negative"); }
            else if (expectedyear > 9999) { throw new ArgumentOutOfRangeException("Year should not contain more than four digits"); }
            else if (expectedyear == 0) { throw new ArgumentOutOfRangeException("Year should not be zero"); } // can combine with <0 test?
            else{year = expectedyear;}
        }

        public void setAbstract(string expectedabstract)
        {
            if (expectedabstract == "") {throw new ArgumentException("Abstract must not be an empty string");}
            else if(expectedabstract == null) {throw new ArgumentNullException("Abstract must not be a null value");}
            else{paperabstract = expectedabstract;}
        }

        public String getTitle()
        {
            return title;
        }

        public List<string> getAuthors()
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

        public List<string> getKeywords()
        {
            return keywords;
        }

        
    }
}
