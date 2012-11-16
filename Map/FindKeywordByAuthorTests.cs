using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Map
{
    [TestClass]
    public class FindKeywordByAuthorTests
    {
        [TestMethod]
        public void FindNormalAuthor()
        {

            //Create a new author with a keyword
            String expectedAuthor = "David Hume";
            String expectedKeyword = "Doppler";

            List<string> expectedkeywords = new List<string>();
            expectedkeywords.Add(expectedKeyword);
            
            Paper existingPaper = new Paper();
            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
            Boolean existAuthor = false;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

            Database papers = new Database();
            Database.addPaper(papers, existingPaper);

            //Check if the author names match
            List<string> actualAuthor = existingPaper.getAuthors();

            foreach (String eAuthor in actualAuthor)
            {
                if (eAuthor == expectedAuthor)
                {
                    exAuthor = eAuthor;
                    existAuthor = true;
                    break;

                }
            }

            if (existAuthor == true)
            {
                Assert.AreEqual(exAuthor, expectedAuthor);
            }

            //Check if the keywords from the author match to the inputed keyword
            List<string> actualKeywords = Database.getKeywordsByAuthor(papers, expectedAuthor);
            Assert.IsTrue(actualKeywords.Contains(expectedKeyword));

           // Assert.AreEqual(expectedkeywords, actualKeywords);
        }

        [TestMethod]
        public void FindPartialNumericalAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor = "Stephaine123456";
            String expectedKeyword = "Turkey";
            Paper existingPaper = new Paper();

            List<string> expectedkeywords = new List<string>();
            expectedkeywords.Add(expectedKeyword);

            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
            Boolean existAuthor = false;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

            Database papers = new Database();
            Database.addPaper(papers, existingPaper);

            //Check if the author names match
            List<string> actualAuthor = existingPaper.getAuthors();

            foreach (String eAuthor in actualAuthor)
            {
                if (eAuthor == expectedAuthor)
                {
                    exAuthor = eAuthor;
                    existAuthor = true;
                    break;

                }
            }

            if (existAuthor == true)
            {
                Assert.AreEqual(exAuthor, expectedAuthor);
            }

            //Check if the keywords from the author match to the inputed keyword
            List<string> actualKeywords = Database.getKeywordsByAuthor(papers, expectedAuthor);
            Assert.IsTrue(actualKeywords.Contains(expectedKeyword));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author must contain letters")]
        public void FindAllNumericalAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor = "4526123456";
            String expectedKeyword = "Fusion";
            Paper existingPaper = new Paper();

            List<string> expectedkeywords = new List<string>();
            expectedkeywords.Add(expectedKeyword);

            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
        }

        [TestMethod]
        public void FindPartialUnicodeAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor = "Nürnberg";
            String expectedKeyword = "Mathematics";
            Paper existingPaper = new Paper();

            List<string> expectedkeywords = new List<string>();
            expectedkeywords.Add(expectedKeyword);

            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
            Boolean existAuthor = false;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

            Database papers = new Database();
            Database.addPaper(papers, existingPaper);

            //Check if the author names match
            List<string> actualAuthor = existingPaper.getAuthors();

            foreach (String eAuthor in actualAuthor)
            {
                if (eAuthor == expectedAuthor)
                {
                    exAuthor = eAuthor;
                    existAuthor = true;
                    break;

                }
            }

            if (existAuthor == true)
            {
                Assert.AreEqual(exAuthor, expectedAuthor);
            }

            //Check if the keywords from the author match to the inputed keyword
            List<string> actualKeywords = Database.getKeywordsByAuthor(papers, expectedAuthor);
            Assert.IsTrue(actualKeywords.Contains(expectedKeyword));
            
        }

        [TestMethod]
        public void FindNoKeywordAuthor()
        {
            String expectedAuthor = "Nürnberg";
            Paper existingPaper = new Paper();

            List<string> expectedkeywords = new List<string>();
            existingPaper.setAuthor(expectedAuthor);
            Boolean existAuthor = false;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

            Database papers = new Database();
            Database.addPaper(papers, existingPaper);
            

            //Check if the author names match
            List<String> actualAuthor = existingPaper.getAuthors(); 
            

            foreach (String eAuthor in actualAuthor)
            {
                if (eAuthor == expectedAuthor)
                {
                    exAuthor = eAuthor;
                    existAuthor = true;
                    break;

                }
            }

            if (existAuthor == true)
            {
                Assert.AreEqual(exAuthor, expectedAuthor);
            }

            List<string> actualKeywords = Database.getKeywordsByAuthor(papers, expectedAuthor);
            Assert.IsTrue(actualKeywords == null);

        }

        [TestMethod]
        public void FindNonExistingAuthor()
        {

            //Create a new author with a keyword
            String expectedAuthor = "John Smith";

            Database papers = new Database();

            List<string> actualKeywords = Database.getKeywordsByAuthor(papers, expectedAuthor);
            Assert.IsTrue(actualKeywords == null);

            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author must contain letters")]
        public void UnicodeAuthor()
        {
            //The input author is unicode symbols
            String expectedAuthor = "╙φ¼╒≥│Θ╛╞";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);

            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Author must not be a null value")]
        public void NullAuthor()
        {
                //The input author is null
                String expectedAuthor = null;
                Paper existingPaper = new Paper();
                existingPaper.setAuthors();
                existingPaper.setAuthor(expectedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author must contain letters")]
        public void SpaceAuthor()
        {
            //The input Author is full if spaces
            String expectedAuthor = "               "; 
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author must contain letters")]
        public void TabAuthor()
        {
            //The input author is full of tabs
            String expectedAuthor = "                 ";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author must not be an empty string")]
        public void emptyAuthor()
        {
            //The input author is a empty string
            String expectedAuthor = "";
            Paper existingPaper = new Paper();

            existingPaper.setAuthor(expectedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author must not be a null value")]
        public void invalidAuthor()
        {
            //The input author is a bunch of text symbols
            String expectedAuthor = "\t \n \t";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);
        }
    }
}
