using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    class Author
    {
        private List<string> existingAuthor;

        public Author(string existingAuthor)
        {
            // TODO: Complete member initialization
            this.existingAuthor.Add(existingAuthor);
        }

        public Author()
        {
            // TODO: Complete member initialization
        }
        internal List<string> listKeywords()
        {
            throw new NotImplementedException();
        }

        internal static string getAuthor()
        {
            throw new NotImplementedException();
        }

        internal List<string> listKeywords(string existingAuthor)
        {
            throw new NotImplementedException();
        }

        internal List<string> addKeyword(string expectedKeyword)
        {
            throw new NotImplementedException();
        }

        internal List<string> getAuthorKeywords(string expectedAuthor)
        {
            throw new NotImplementedException();
        }

        internal string getAuthorName()
        {
            throw new NotImplementedException();
        }

        internal List<string> getAuthors()
        {
            throw new NotImplementedException();
        }

        internal void findAuthor(string nonExistingAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
