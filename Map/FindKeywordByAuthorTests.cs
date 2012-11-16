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
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setKeywords();
            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
            Boolean existAuthor = false;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

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

            List<String> actualKeywords = existingPaper.getKeywords();

            foreach (String Keyword in actualKeywords)
            {
                if (Keyword == expectedKeyword)
                {
                    exKeyword = Keyword;
                    existKeyword = true;
                    break;

                }
            }

            if (existKeyword == true)
            {
                Assert.AreEqual(exKeyword, expectedKeyword);
            }
        }

        [TestMethod]
        public void FindPartialNumericalAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor = "Stephaine123456";
            String expectedKeyword = "Turkey";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setKeywords();
            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
            Boolean existAuthor = false;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

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

            List<String> actualKeywords = existingPaper.getKeywords();

            foreach (String Keyword in actualKeywords)
            {
                if (Keyword == expectedKeyword)
                {
                    exKeyword = Keyword;
                    existKeyword = true;
                    break;

                }
            }

            if (existKeyword == true)
            {
                Assert.AreEqual(exKeyword, expectedKeyword);
            }
        }

        [TestMethod]
        public void FindAllNumericalAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor = "4526123456";
            String expectedKeyword = "Fusion";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setKeywords();
            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
            Boolean existAuthor = false;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

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

            List<String> actualKeywords = existingPaper.getKeywords();

            foreach (String Keyword in actualKeywords)
            {
                if (Keyword == expectedKeyword)
                {
                    exKeyword = Keyword;
                    existKeyword = true;
                    break;

                }
            }

            if (existKeyword == true)
            {
                Assert.AreEqual(exKeyword, expectedKeyword);
            }
        }

        [TestMethod]
        public void FindPartialUnicodeAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor = "Nürnberg";
            String expectedKeyword = "Mathematics";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setKeywords();
            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
            Boolean existAuthor = false;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

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

            List<String> actualKeywords = existingPaper.getKeywords();

            foreach (String Keyword in actualKeywords)
            {
                if (Keyword == expectedKeyword)
                {
                    exKeyword = Keyword;
                    existKeyword = true;
                    break;

                }
            }

            if (existKeyword == true)
            {
                Assert.AreEqual(exKeyword, expectedKeyword);
            }
            
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException), "Author has no keywords")]
        public void FindNoKeywordAuthor()
        {
            String expectedAuthor = "Nürnberg";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);
            Boolean existAuthor = false;
            Boolean existKeyword = true;
            String exAuthor = "";
            

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

            List<String> nonexistingKeywords = existingPaper.getKeywords();
            Assert.AreEqual(null, nonexistingKeywords);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Author does not exist")]
        public void FindNonExistingAuthor()
        {

            //Create a new author with a keyword
            String expectedAuthor = "John Smith";
            String expectedKeyword = "Fusion";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setKeywords();
            existingPaper.setAuthor(expectedAuthor);
            existingPaper.addKeyword(expectedKeyword);
            Boolean existAuthor = false;
            Boolean noExistingAuthor = true;
            Boolean existKeyword = false;
            String exAuthor = "";
            String exKeyword = "";

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

            List<String> actualKeywords = existingPaper.getKeywords();

            foreach (String Keyword in actualKeywords)
            {
                if (Keyword == expectedKeyword)
                {
                    exKeyword = Keyword;
                    existKeyword = true;
                    break;

                }
            }

            if (existKeyword == true)
            {
                Assert.AreEqual(exKeyword, expectedKeyword);
            }


           

            //Raises an error if the author does not exist
            List<String> noactualAuthors = existingPaper.getAuthors();
            String nonExistingAuthor = "Mei Wang";
            
            foreach (String eAuthor in noactualAuthors)
            {
                if (eAuthor == nonExistingAuthor)
                {
                    exAuthor = eAuthor;
                    noExistingAuthor = false;
                    break;

                }
            }

            if (noExistingAuthor == true)
            {
                Assert.AreEqual(true, noExistingAuthor);
            }
            
            
          
            //Assert.AreEqual(noExistingAuthor, true);
            
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Author name is invalid")]
        public void UnicodeAuthor()
        {
            //The input author is unicode symbols
            String expectedAuthor = "╙φ¼╒≥│Θ╛╞";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);

            
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Author name is invalid")]
        public void NullAuthor()
        {
                //The input author is null
                String expectedAuthor = null;
                Paper existingPaper = new Paper();
                existingPaper.setAuthors();
                existingPaper.setAuthor(expectedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Text field is empty")]
        public void SpaceAuthor()
        {
            //The input Author is full if spaces
            String expectedAuthor = "               "; 
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Text field is empty")]
        public void TabAuthor()
        {
            //The input author is full of tabs
            String expectedAuthor = "                 ";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Text field is empty")]
        public void emptyAuthor()
        {
            //The input author is a empty string
            String expectedAuthor = "";
            Paper existingPaper = new Paper();
            existingPaper.setAuthors();
            existingPaper.setAuthor(expectedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Invalid author name")]
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
