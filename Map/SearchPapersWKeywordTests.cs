using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Map
{
    /*  As a principal investigator, I want to search for all papers with
     *  a given keyword so that I can find out how common keywords are.  */
    [TestClass]
    public class SearchPapersWKeywordTests
    {
        [TestMethod]
        public void SearchNormal_ExistingKeyword_SinglePaper()
        {
            //  create paper with keyword of "Doppler Effect"
            String existingKeyword = "Doppler Effect";
            Paper existingPaper = new Paper();
            existingPaper.addKeyword(existingKeyword);

            //  add paper to a database
            Database allPapers = new Database();
            Database.addPaper(allPapers, existingPaper);

            //  search database using keyword of "Doppler Effect"
            List<Paper> searchedPaper = Database.searchByKeyword(allPapers, existingKeyword);

            //  check if search result returns null (found no matches for "Doppler Effect")
            if (searchedPaper == null) Assert.Fail();

            //  check if search result matches the added paper
            Assert.AreEqual(existingPaper, searchedPaper[0]);
        }

        [TestMethod]
        public void SearchNormal_NonExistingKeyword()
        {
            //  create paper with keyword of "Doppler Effect"
            String existingKeyword = "Doppler Effect";
            Paper existingPaper = new Paper();
            existingPaper.addKeyword(existingKeyword);

            //  add paper to a database
            Database allPapers = new Database();
            Database.addPaper(allPapers, existingPaper);

            //  search database using non-existing keyword of "Fusion"
            String nonExistingKeyword = "Fusion";
            List<Paper> searchedPaper = Database.searchByKeyword(allPapers, nonExistingKeyword);

            //  check if search result returns null (found no matches for "Fusion")
            Assert.AreEqual(searchedPaper, null);
        }

        [TestMethod]
        public void SearchNormal_ExistingKeyword_MultiplePapers()
        {
            //  create database, existing papers array, and define existing keyword of "Doppler Effect"
            String existingKeyword = "Doppler Effect";
            Database allPapers = new Database();
            Paper [] existingPaper = new Paper [2];

            //  apply existing keyword across multiple papers and add those papers to database
            for (int i = 0; i < 2; i++)
            {
                //  create paper with existing keyword
                existingPaper[i] = new Paper();
                existingPaper[i].addKeyword(existingKeyword);

                //  add paper to a database
                Database.addPaper(allPapers, existingPaper[i]);
            }

            //  search database using keyword of "Doppler Effect"
            List<Paper> searchedPaper = Database.searchByKeyword(allPapers, existingKeyword);

            //  check if search result returns null (found no matches for "Doppler Effect")
            if (searchedPaper == null) Assert.Fail();

            //  check if search results match the added papers
            Assert.AreEqual(existingPaper[0], searchedPaper[0]);
            Assert.AreEqual(existingPaper[1], searchedPaper[1]);
        }

        [TestMethod]
        public void SearchProblem_NullKeywordGiven()
        {
            //  create paper with keyword of "Doppler Effect"
            String existingKeyword = "Doppler Effect";
            Paper existingPaper = new Paper();
            existingPaper.addKeyword(existingKeyword);

            //  add paper to a database
            Database allPapers = new Database();
            Database.addPaper(allPapers, existingPaper);

            //  search database using null keyword
            List<Paper> searchedPaper = Database.searchByKeyword(allPapers, null);

            //  check if search result returns null (found no matches for null keyword)
            Assert.AreEqual(searchedPaper, null);
        }

        [TestMethod]
        public void SearchProblem_EmptyKeywordGiven()
        {
            //  create paper with keyword of "Doppler Effect"
            String existingKeyword = "Doppler Effect";
            Paper existingPaper = new Paper();
            existingPaper.addKeyword(existingKeyword);

            //  add paper to a database
            Database allPapers = new Database();
            Database.addPaper(allPapers, existingPaper);

            //  search database using empty keyword
            String searchKeyword = "";
            List<Paper> searchedPaper = Database.searchByKeyword(allPapers, searchKeyword);

            //  check if search result returns null (found no matches for empty keyword)
            Assert.AreEqual(searchedPaper, null);
        }

        [TestMethod]
        public void SearchProblem_EmptyDatabase()
        {
            //  create empty database
            Database allPapers = new Database();

            //  search empty database using "Doppler Effect"
            String searchKeyword = "Doppler Effect";
            List<Paper> searchedPaper = Database.searchByKeyword(allPapers, searchKeyword);

            //  check if search result returns null (found no matches for "Doppler Effect")
            Assert.AreEqual(searchedPaper, null);
        }

        [TestMethod]
        public void SearchProblem_NullDatabase()
        {
            //  create non-existent database
            Database allPapers = null;

            //  search non-existent database using "Doppler Effect"
            String searchKeyword = "Doppler Effect";
            List<Paper> searchedPaper = Database.searchByKeyword(allPapers, searchKeyword);
            Database.searchByKeyword(allPapers, searchKeyword);

            //  check if search result returns null (found no matches for "Doppler Effect")
            Assert.AreEqual(searchedPaper, null);
        }
    }
}
