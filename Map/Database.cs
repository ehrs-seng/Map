using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class Database
    {
        List<Paper> papers;

        public Database()
        {
            papers = new List<Paper>();
        }

        public List<Paper> getPapers()
        {
            return papers;
        }

        public void addPaper(Paper existingPaper)
        {
            papers.Add(existingPaper);
        }

        internal List<string> searchByAuthor(Database allPapers, string expectedAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
