using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class Database
    {
        List<Paper> papers;

        public List<Paper> getPapers()
        {
            return papers;
        }

        internal void addPaper(Paper existingPaper)
        {
            throw new NotImplementedException();
        }

        internal List<string> searchByAuthor(Database allPapers, string expectedAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
