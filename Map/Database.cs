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

        public static void deleteAllPapers(Database database)
        {
            // verify that arguments are valid
            if (database == null) return;

            // clear database's papers
            database.allPapers.Clear();
        }

        public static void deletePaperByAbstract(Database database, string expectedAbstract)
        {
            // verify that arguments are valid
            if (expectedAbstract == "") return;
            if (expectedAbstract == null) return;
            if (database == null) return;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if a paper is found that matches the query, delete from the database
                if (string.Equals(Database.getAllPapers(database).ElementAt(i).getAbstract(), expectedAbstract) == true)
                    Database.getAllPapers(database).RemoveAt(i);
            }
        }

        public static void deletePaperByAuthor(Database database, string expectedAuthor)
        {
            // verify that arguments are valid
            if (expectedAuthor == "") return;
            if (expectedAuthor == null) return;
            if (database == null) return;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // scan through this paper's authors
                for (int j = 0; j < Database.getAllPapers(database).ElementAt(i).listAuthors().Count; j++)
                {
                    // if a paper is found that matches the query, delete from the database
                    if (string.Equals(Database.getAllPapers(database).ElementAt(i).listAuthors().ElementAt(j), expectedAuthor) == true)
                    {
                        Database.getAllPapers(database).RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public static void deletePaperByDatabaseID(Database database, int ID)
        {
            // verify that arguments are valid
            if (ID < 0) return;
            if (database == null) return;

            // delete paper at element position ID from database
            Database.getAllPapers(database).RemoveAt(ID);
        }

        public static void deletePaperByKeyword(Database database, string expectedKeyword)
        {
            // verify that arguments are valid
            if (expectedKeyword == "") return;
            if (expectedKeyword == null) return;
            if (database == null) return;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // scan through this paper's keywords
                for (int j = 0; j < Database.getAllPapers(database).ElementAt(i).listKeywords().Count; j++)
                {
                    // if a paper is found that matches the query, delete from the database
                    if (string.Equals(Database.getAllPapers(database).ElementAt(i).listKeywords().ElementAt(j), expectedKeyword) == true)
                    {
                        Database.getAllPapers(database).RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public static void deletePaperByPaperReference(Database database, Paper query)
        {
            // verify that arguments are valid
            if (query == null) return;
            if (database == null) return;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if this paper's reference matches the query's reference, the paper is found
                // delete this paper from database
                if (Database.getAllPapers(database).ElementAt(i) == query)
                    Database.getAllPapers(database).RemoveAt(i);
            }
        }

        public static void deletePaperByTitle(Database database, string expectedTitle)
        {
            // verify that arguments are valid
            if (expectedTitle == "") return;
            if (expectedTitle == null) return;
            if (database == null) return;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if a paper is found that matches the query, delete from the database
                if (string.Equals(Database.getAllPapers(database).ElementAt(i).getTitle(), expectedTitle) == true)
                    Database.getAllPapers(database).RemoveAt(i);
            }
        }

        public static void deletePaperByYear(Database database, int expectedYear)
        {
            // verify that arguments are valid
            if (expectedYear < 0) return;
            if (database == null) return;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if a paper is found that matches the query, delete from the database
                if (Database.getAllPapers(database).ElementAt(i).getYear() == expectedYear)
                    Database.getAllPapers(database).RemoveAt(i);
            }
        }

        public static List<Paper> getAllPapers(Database database)
        {
            // verify that arguments are valid
            if (database == null) return null;

            // return database's papers
            return database.allPapers;
        }

        public static int getDatabaseIDByPaperReference(Database database, Paper query)
        {
            // verify that arguments are valid
            if (query == null) return -1;
            if (database == null) return -1;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if this paper's reference matches the query's reference, the paper is found
                // return this index
                if (Database.getAllPapers(database).ElementAt(i) == query)
                    return i;
            }

            // return -1 if no paper found
            return -1;
        }

        public static Paper getPaperByDatabaseID(Database database, int ID)
        {
            // verify that arguments are valid
            if (ID < 0) return null;
            if (database == null) return null;

            // return paper at element position ID
            return Database.getAllPapers(database).ElementAt(ID);
        }

        public static List<Paper> searchByAbstract(Database database, string expectedAbstract)
        {
            // verify that arguments are valid
            if (expectedAbstract == "") return null;
            if (expectedAbstract == null) return null;
            if (database == null) return null;

            List<Paper> result = new List<Paper>();

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if a paper is found that matches the query, add to result list
                if (string.Equals(Database.getAllPapers(database).ElementAt(i).getAbstract(), expectedAbstract) == true)
                    result.Add(Database.getAllPapers(database).ElementAt(i));
            }

            if (result.Count > 0) return result;
            else return null;
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
                for (int j = 0; j < Database.getAllPapers(database).ElementAt(i).listAuthors().Count; j++)
                {
                    // if a paper is found that matches the query, add to result list
                    if (string.Equals(Database.getAllPapers(database).ElementAt(i).listAuthors().ElementAt(j), expectedAuthor) == true)
                    {
                        result.Add(Database.getAllPapers(database).ElementAt(i));
                        break;
                    }
                }
            }

            if (result.Count > 0) return result;
            else return null;
        }

        public static List<Paper> searchByAuthors(Database database, List<string> expectedAuthors)
        {
            // verify that arguments are valid
            for (int i = 0; i < expectedAuthors.Count; i++)
            {
                if (expectedAuthors.ElementAt(i) == "") return null;
                if (expectedAuthors.ElementAt(i) == null) return null;
            }
            if (database == null) return null;

            List<Paper> result = new List<Paper>();
            bool paperUsed = false;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // scan through this paper's authors
                for (int j = 0; j < Database.getAllPapers(database).ElementAt(i).listAuthors().Count; j++)
                {
                    // scan through queried authors
                    for (int k = 0; k < expectedAuthors.Count; k++)
                    {
                        // if a paper is found that matches the query, add to result list
                        if (string.Equals(Database.getAllPapers(database).ElementAt(i).listAuthors().ElementAt(j),
                                            expectedAuthors.ElementAt(k)) == true)
                        {
                            result.Add(Database.getAllPapers(database).ElementAt(i));
                            paperUsed = true;
                            break;
                        }
                    }
                    // check flag if paper is used to break 'j' loop
                    if (paperUsed == true)
                    {
                        paperUsed = false;
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
                for (int j = 0; j < Database.getAllPapers(database).ElementAt(i).listKeywords().Count; j++)
                {
                    // if a paper is found that matches the query, add to result list
                    if (string.Equals(Database.getAllPapers(database).ElementAt(i).listKeywords().ElementAt(j), expectedKeyword) == true)
                    {
                        result.Add(Database.getAllPapers(database).ElementAt(i));
                        break;
                    }
                }
            }

            if (result.Count > 0) return result;
            else return null;
        }

        public static List<Paper> searchByKeywords(Database database, List<string> expectedKeywords)
        {
            // verify that arguments are valid
            for (int i = 0; i < expectedKeywords.Count; i++)
            {
                if (expectedKeywords.ElementAt(i) == "") return null;
                if (expectedKeywords.ElementAt(i) == null) return null;
            }
            if (database == null) return null;

            List<Paper> result = new List<Paper>();
            bool paperUsed = false;

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // scan through this paper's keywords
                for (int j = 0; j < Database.getAllPapers(database).ElementAt(i).listKeywords().Count; j++)
                {
                    // scan through queried keywords
                    for (int k = 0; k < expectedKeywords.Count; k++)
                    {
                        // if a paper is found that matches the query, add to result list
                        if (string.Equals(Database.getAllPapers(database).ElementAt(i).listKeywords().ElementAt(j),
                                            expectedKeywords.ElementAt(k)) == true)
                        {
                            result.Add(Database.getAllPapers(database).ElementAt(i));
                            paperUsed = true;
                            break;
                        }
                    }
                    // check flag if paper is used to break 'j' loop
                    if (paperUsed == true)
                    {
                        paperUsed = false;
                        break;
                    }
                }
            }

            if (result.Count > 0) return result;
            else return null;
        }

        public static List<Paper> searchByTitle(Database database, string expectedTitle)
        {
            // verify that arguments are valid
            if (expectedTitle == "") return null;
            if (expectedTitle == null) return null;
            if (database == null) return null;

            List<Paper> result = new List<Paper>();

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if a paper is found that matches the query, add to result list
                if (string.Equals(Database.getAllPapers(database).ElementAt(i).getTitle(), expectedTitle) == true)
                    result.Add(Database.getAllPapers(database).ElementAt(i));
            }

            if (result.Count > 0) return result;
            else return null;
        }

        public static List<Paper> searchByYear(Database database, int expectedYear)
        {
            // verify that arguments are valid
            if (expectedYear < 0) return null;
            if (database == null) return null;

            List<Paper> result = new List<Paper>();

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if a paper is found that matches the query, add to result list
                if (Database.getAllPapers(database).ElementAt(i).getYear() == expectedYear)
                    result.Add(Database.getAllPapers(database).ElementAt(i));
            }

            if (result.Count > 0) return result;
            else return null;
        }

        public static List<string> getKeywordsByPapers(List<Paper> paperList)
        {
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
            return keywordsList;
        }
    }
}
