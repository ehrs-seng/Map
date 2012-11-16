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
		
		public Database(List<Paper> existingPapers)
		{
			allPapers = existingPapers;
		}
		
		~Database()
		{
			for(int i = 0; i < allPapers.Count(); i++)
			{
				allPapers.ElementAt(i).clearPaper();
			}
			allPapers.Clear();
		}

        internal static void addAuthorToPaperByDatabaseID(Database database, int existingID, string expectedAuthor)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();
            if (expectedAuthor == null) throw new ArgumentNullException();
            if (expectedAuthor == "") throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.addAuthor(expectedAuthor);
        }

        internal static void addAuthorToPaperByPaperReference(Paper existingPaper, string expectedAuthor)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();
            if (expectedAuthor == null) throw new ArgumentNullException();
            if (expectedAuthor == "") throw new ArgumentException();

            // add author to paper
            existingPaper.addAuthor(expectedAuthor);
        }

        internal static void addKeywordToPaperByDatabaseID(Database database, int existingID, string expectedKeyword)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();
            if (expectedKeyword == null) throw new ArgumentNullException();
            if (expectedKeyword == "") throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.addKeyword(expectedKeyword);
        }

        internal static void addKeywordToPaperByPaperReference(Paper existingPaper, string expectedKeyword)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();
            if (expectedKeyword == null) throw new ArgumentNullException();
            if (expectedKeyword == "") throw new ArgumentException();

            // add keyword to paper
            existingPaper.addKeyword(expectedKeyword);
        }

        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

            // add paper to database
            Database.getAllPapers(database).Add(existingPaper);
        }

        public static void deleteAllPapers(Database database)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();

            // clear database's papers
            database.allPapers.Clear();
        }

        internal static void deleteAbstractFromPaperByDatabaseID(Database database, int existingID)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.deleteAbstract();
        }

        internal static void deleteAbstractFromPaperByPaperReference(Paper existingPaper)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();

            // add keyword to paper
            existingPaper.deleteAbstract();
        }

        internal static void deleteAuthorFromPaperByDatabaseID(Database database, int existingID, string expectedAuthor)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();
            if (expectedAuthor == null) throw new ArgumentNullException();
            if (expectedAuthor == "") throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.deleteAuthor(expectedAuthor);
        }

        internal static void deleteAuthorFromPaperByPaperReference(Paper existingPaper, string expectedAuthor)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();
            if (expectedAuthor == null) throw new ArgumentNullException();
            if (expectedAuthor == "") throw new ArgumentException();

            // add author to paper
            existingPaper.deleteAuthor(expectedAuthor);
        }

        internal static void deleteKeywordFromPaperByDatabaseID(Database database, int existingID, string expectedKeyword)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();
            if (expectedKeyword == null) throw new ArgumentNullException();
            if (expectedKeyword == "") throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.deleteKeyword(expectedKeyword);
        }

        internal static void deleteKeywordFromPaperByPaperReference(Paper existingPaper, string expectedKeyword)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();
            if (expectedKeyword == null) throw new ArgumentNullException();
            if (expectedKeyword == "") throw new ArgumentException();

            // add keyword to paper
            existingPaper.deleteKeyword(expectedKeyword);
        }

        {
            // verify that arguments are valid
            if (expectedAbstract == "") throw new ArgumentException();
            if (expectedAbstract == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
            if (expectedAuthor == "") throw new ArgumentException();
            if (expectedAuthor == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
            if (ID < 0) throw new ArgumentException();
            if (database == null) throw new ArgumentNullException();

            // delete paper at element position ID from database
            Database.getAllPapers(database).RemoveAt(ID);
        }

        public static void deletePaperByKeyword(Database database, string expectedKeyword)
        {
            // verify that arguments are valid
            if (expectedKeyword == "") throw new ArgumentException();
            if (expectedKeyword == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
            if (query == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
            if (expectedTitle == "") throw new ArgumentException();
            if (expectedTitle == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
            if (expectedYear < 0) throw new ArgumentException();
            if (database == null) throw new ArgumentNullException();

            // scan through all papers
            for (int i = 0; i < Database.getAllPapers(database).Count; i++)
            {
                // if a paper is found that matches the query, delete from the database
                if (Database.getAllPapers(database).ElementAt(i).getYear() == expectedYear)
                    Database.getAllPapers(database).RemoveAt(i);
            }
        }

        internal static void deleteTitleFromPaperByDatabaseID(Database database, int existingID)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.deleteTitle();
        }

        internal static void deleteTitleFromPaperByPaperReference(Paper existingPaper)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();

            // add keyword to paper
            existingPaper.deleteTitle();
        }

        internal static void deleteYearFromPaperByDatabaseID(Database database, int existingID)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.deleteYear();
        }

        internal static void deleteYearFromPaperByPaperReference(Paper existingPaper)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();

            // add keyword to paper
            existingPaper.deleteYear();
        }

        internal static void editAbstractOfPaperByDatabaseID(Database database, int existingID, string expectedAbstract)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();
            if (expectedAbstract == null) throw new ArgumentNullException();
            if (expectedAbstract == "") throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.setAbstract(expectedAbstract);
        }

        internal static void editAbstractOfPaperByPaperReference(Paper existingPaper, string expectedAbstract)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();
            if (expectedAbstract == null) throw new ArgumentNullException();
            if (expectedAbstract == "") throw new ArgumentException();

            // add keyword to paper
            existingPaper.setAbstract(expectedAbstract);
        }

        internal static void editTitleOfPaperByDatabaseID(Database database, int existingID, string expectedTitle)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();
            if (expectedTitle == null) throw new ArgumentNullException();
            if (expectedTitle == "") throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.setTitle(expectedTitle);
        }

        internal static void editTitleOfPaperByPaperReference(Paper existingPaper, string expectedTitle)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();
            if (expectedTitle == null) throw new ArgumentNullException();
            if (expectedTitle == "") throw new ArgumentException();

            // add keyword to paper
            existingPaper.setTitle(expectedTitle);
        }

        internal static void editYearOfPaperByDatabaseID(Database database, int existingID, int expectedYear)
        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();
            if (existingID < 0) throw new ArgumentException();
            if (expectedYear == null) throw new ArgumentNullException();
            if (expectedYear < 0) throw new ArgumentException();

            // find paper in all papers
            Paper paper = Database.getPaperByDatabaseID(database, existingID);
            paper.setYear(expectedYear);
        }

        internal static void editYearOfPaperByPaperReference(Paper existingPaper, int expectedYear)
        {
            // verify that arguments are valid
            if (existingPaper == null) throw new ArgumentNullException();
            if (expectedYear == null) throw new ArgumentNullException();
            if (expectedYear < 0) throw new ArgumentException();

            // add keyword to paper
            existingPaper.setYear(expectedYear);
        }

        {
            // verify that arguments are valid
            if (database == null) throw new ArgumentNullException();

            // return database's papers
            return database.allPapers;
        }

        public static int getDatabaseIDByPaperReference(Database database, Paper query)
        {
            // verify that arguments are valid
            if (query == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
            if (ID < 0) throw new ArgumentException();
            if (database == null) throw new ArgumentNullException();

            // return paper at element position ID
            return Database.getAllPapers(database).ElementAt(ID);
        }

        public static List<Paper> searchByAbstract(Database database, string expectedAbstract)
        {
            // verify that arguments are valid
            if (expectedAbstract == "") throw new ArgumentException();
            if (expectedAbstract == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
            if (expectedAuthor == "") throw new ArgumentException();
            if (expectedAuthor == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
                if (expectedAuthors.ElementAt(i) == "") throw new ArgumentException();
                if (expectedAuthors.ElementAt(i) == null) throw new ArgumentNullException();
            }
            if (database == null) throw new ArgumentNullException();

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
            if (expectedKeyword == "") throw new ArgumentException();
            if (expectedKeyword == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
                if (expectedKeywords.ElementAt(i) == "") throw new ArgumentException();
                if (expectedKeywords.ElementAt(i) == null) throw new ArgumentNullException();
            }
            if (database == null) throw new ArgumentNullException();

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
            if (expectedTitle == "") throw new ArgumentException();
            if (expectedTitle == null) throw new ArgumentNullException();
            if (database == null) throw new ArgumentNullException();

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
            if (expectedYear < 0) throw new ArgumentException();
            if (database == null) throw new ArgumentNullException();

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
    }
}
