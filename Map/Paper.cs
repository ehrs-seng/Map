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
            // allocate memory for list objects
            authors = new List<string>();
            keywords = new List<string>();
        }

        public void setAuthors()
        {
            // allocating memory for list - left in because of dependencies
            authors = new List<string>();
        }

        public void setKeywords()
        {
            // allocating memory for list - left in because of dependencies
            keywords = new List<string>();
        }
        
        public void addKeyword(string p)
        {
            //Check if duplicate
            if (keywords.Contains(p))
            {
                throw new ArgumentException("No duplicate keywords allowed.");
            }
            //check if empty
            else if (p == "")
            {
                throw new ArgumentException("Keywords must not be an empty string");
            }
            //check if there are no letters
            else if(!System.Text.RegularExpressions.Regex.IsMatch(p, "[a-z]|[A-Z]"))
            {
                throw new ArgumentException("Keywords must contain letters");
            }
            //check if null
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
            //check if empty
            if (expectedtitle == "") { throw new ArgumentException("Title must not be an empty string"); }
            //check if null
            else if(expectedtitle == null){throw new ArgumentNullException("Title must not be a null value");}
            else{title = expectedtitle;}
        }
        
        public void setAuthor(string expectedauthor)
        {
            //check if empty
            if (expectedauthor == "")
            {
                throw new ArgumentException("Author must not be an empty string");
            }
            //check if there are no letters
            else if (!System.Text.RegularExpressions.Regex.IsMatch(expectedauthor, "[a-z]|[A-Z]"))
            {
                throw new ArgumentException("Author must contain letters");
            }
            //check if null
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
            //check if negative
            if (expectedyear < 0) { throw new ArgumentOutOfRangeException("Year must not be negative"); }
            //check if year exceeds limit
            else if (expectedyear > 9999) { throw new ArgumentOutOfRangeException("Year should not contain more than four digits"); }
            //check if 0
            else if (expectedyear == 0) { throw new ArgumentOutOfRangeException("Year should not be zero"); } // can combine with <0 test?
            else{year = expectedyear;}
        }

        public void setAbstract(string expectedabstract)
        {
            //check if empty
            if (expectedabstract == "") {throw new ArgumentException("Abstract must not be an empty string");}
            //check if null
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
