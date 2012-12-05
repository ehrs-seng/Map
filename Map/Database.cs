using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class Database
    {
        private List<Paper> allPapers;
        private List<ResearchAssistant> allResearchAssistants;
        private List<PrincipalInvestigator> allPrincipalInvestigators;

        public Database()
        {
            allPapers = new List<Paper>();
            allResearchAssistants = new List<ResearchAssistant>();
            allPrincipalInvestigators = new List<PrincipalInvestigator>();
        }

        public static void addResearchAssistant(Database database, ResearchAssistant ra)
        {
            // if arguments are null, return
            if (database == null) return;
            if (ra == null) return;

            // if database doesn't contain this research assistant, add to database
            if (database.allResearchAssistants.Contains(ra) == false)
                database.allResearchAssistants.Add(ra);
        }

        public static List<ResearchAssistant> getResearchAssistants(Database database)
        {
            // if arguments are null, return
            if (database == null) return null;

            // if no research assistants, return null
            if (database.allResearchAssistants.Count <= 0) return null;

            // return this database's research assistants
            return database.allResearchAssistants;
        }

        public static void addPrincipalInvestigator(Database database, PrincipalInvestigator pi)
        {
            // if arguments are null, return
            if (database == null) return;
            if (pi == null) return;

            // if database doesn't contain this principal investigator, add to database
            if (database.allPrincipalInvestigators.Contains(pi) == false)
                database.allPrincipalInvestigators.Add(pi);
        }

        public static List<PrincipalInvestigator> getPrincipalInvestigators(Database database)
        {
            // if arguments are null, return
            if (database == null) return null;

            // if no principal investigators, return null
            if (database.allPrincipalInvestigators.Count <= 0) return null;

            // return this database's principal investigators
            return database.allPrincipalInvestigators;
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

        //this is a helper method for getKeywordsByAuthor
        private static List<string> getKeywordsByPapers(List<Paper> paperList)
        {
            //check if null
            if (paperList == null) return null;

            //for all papers in the list, compile their keywords in a list
            List<string> keywordsList = new List<string>();
            for(int i = 0; i<paperList.Count; i++)
            {
                List<string> keywords = paperList[i].getKeywords();
                for (int j = 0; j < keywords.Count; j++)
                {
                    //checking if keyword is already in list
                    if (!keywordsList.Contains(keywords[j]))
                    {
                        keywordsList.Add(keywords[j]);
                    }
                }
            }

            //if list is empty return null
            if (keywordsList.Count == 0) return null;
            return keywordsList;
        }

        public static List<string> getKeywordsByAuthor(Database d, string author)
        {
            //find papers by author
            List<Paper> papers = Database.searchByAuthor(d, author);
            //compile list of keywords for those papers
            List<string> keywords = Database.getKeywordsByPapers(papers);

            return keywords;
            
        }

        // CASE 4 IF IT IMPLIES GETTING ALL KEYWORDS IN EVERY PAPER IN DATABASE
        public static List<string> getAllKeywordsInDatabase(Database d)
        {
            // allocate return list
            List<string> allKeywords = new List<string>();

            // scan through all papers in database
            foreach (Paper p in getAllPapers(d))
            {
                // scan through all keywords in this paper
                foreach (string keyword in p.getKeywords())
                {
                    // if return list does not contain this keyword, add it
                    if (allKeywords.Contains(keyword) == false)
                        allKeywords.Add(keyword);
                }
            }

            // if return list is empty, return null.  Otherwise, return the keyword list
            if (allKeywords.Count == 0) return null;
            return allKeywords;
        }

        // CASE 4 IF IT IMPLIES GETTING ALL KEYWORDS IN A SINGLE PAPER
        public static List<string> getAllKeywordsInPaper(Paper p)
        {
            // allocate return list
            List<string> allKeywords = new List<string>();

            // scan through all keywords in this paper
            foreach (string keyword in p.getKeywords())
            {
                // if return list does not contain this keyword, add it
                if (allKeywords.Contains(keyword) == false)
                    allKeywords.Add(keyword);
            }

            // if return list is empty, return null.  Otherwise, return the keyword list
            if (allKeywords.Count == 0) return null;
            return allKeywords;
        }
    }
}
