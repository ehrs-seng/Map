using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    class searchKWbyA
    {

        internal List<string> searchkeywordsbyauthor(Database database, string Author)
        {
            List<Paper> papersByAuthor = new List<Paper>();
            List<string> keywords = new List<string>;

            papersByAuthor = Database.searchByAuthor(database, Author);

            foreach (Paper authorPaper in papersByAuthor)
            {



            }

            return keywords;





        }

    }
}
