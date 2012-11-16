using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class Database
    {
        private List<Paper> allPapers;

        public Database()
        {
            allPapers = new List<Paper>();
        }

        public static void addPaper(Database database, Paper existingPaper)
        {
            // verify that arguments are valid
            if (existingPaper == null) return;
            if (database == null) return;

            // add paper to database
            Database.getAllPapers(database).Add(existingPaper);
        }


        public static List<Paper> getAllPapers(Database database)
        {
            // verify that arguments are valid
            if (database == null) return null;

            // return database's papers
            return database.allPapers;
        }

        public static List<Paper> searchByAuthor(Database database, string expectedAuthor)
        {
            // verify that arguments are valid
            if (expectedAuthor == "") return null;
            if (expectedAuthor == null) return null;
            if (database == null) return null;

            List<Paper> result = new List<Paper>();

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // scan through this paper's authors
                for (int j = 0; j < Database.getAllPapers(database).ElementAt(i).getAuthors().Count; j++)
                {
                    // if a paper is found that matches the query, add to result list
                    if (string.Equals(Database.getAllPapers(database).ElementAt(i).getAuthors().ElementAt(j), expectedAuthor) == true)
                    {
                        result.Add(Database.getAllPapers(database).ElementAt(i));
                        break;
                    }
                }
            }

            if (result.Count > 0) return result;
            else return null;
        }

        public static List<Paper> searchByKeyword(Database database, string expectedKeyword)
        {
            // verify that arguments are valid
            if (expectedKeyword == "") return null;
            if (expectedKeyword == null) return null;
            if (database == null) return null;

            List<Paper> result = new List<Paper>();

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // scan through this paper's keywords
                for (int j = 0; j < Database.getAllPapers(database).ElementAt(i).getKeywords().Count; j++)
                {
                    // if a paper is found that matches the query, add to result list
                    if (string.Equals(Database.getAllPapers(database).ElementAt(i).getKeywords().ElementAt(j), expectedKeyword) == true)
                    {
                        result.Add(Database.getAllPapers(database).ElementAt(i));
                        break;
                    }
                }
            }

            if (result.Count > 0) return result;
            else return null;
        }

        public static List<string> getKeywordsByPapers(List<Paper> paperList)
        {
            if (paperList == null) return null;

            List<string> keywordsList = new List<string>();
            for(int i = 0; i<paperList.Count; i++)
            {
                List<string> keywords = paperList[i].getKeywords();
                for (int j = 0; j < keywords.Count; j++)
                {
                    if (!keywordsList.Contains(keywords[j]))
                    {
                        keywordsList.Add(keywords[j]);
                    }
                }
            }

            if (keywordsList.Count == 0) return null;
            return keywordsList;
        }

        public static List<string> getKeywordsByAuthor(Database d, string author)
        {
            List<Paper> papers = Database.searchByAuthor(d, author);
            List<string> keywords = Database.getKeywordsByPapers(papers);

            return keywords;
            
        }
    }
}
