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
            Author a = new Author(expectedAuthor);
            String expectedKeyword = "Doppler";
            a.addKeyword(expectedKeyword);

            //Check if the author names match
            List<String> actualAuthorList = a.getAuthors();
            String actualAuthor = actualAuthorList.Find(s => s == expectedAuthor);
            Assert.AreEqual(actualAuthor, expectedAuthor);

            //Check if the keywords from the author match to the inputed keyword
            List<String> actualKeywords = a.getAuthorKeywords(expectedAuthor);
            String actual = actualKeywords.Find(s => s == expectedKeyword);
            Assert.AreEqual(actualKeywords, expectedKeyword);
        }

        [TestMethod]
        public void FindPartialNumericalAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor = "Stephaine123456";
            Author a = new Author(expectedAuthor);
            String expectedKeyword = "Turkey";
            a.addKeyword(expectedKeyword);

            //Check if the author names match
            List<String> actualAuthorList = a.getAuthors();
            String actualAuthor = actualAuthorList.Find(s => s == expectedAuthor);
            Assert.AreEqual(actualAuthor, expectedAuthor);

            //Check if the keywords from the author match to the inputed keyword
            List<String> actualKeywords = a.getAuthorKeywords(expectedAuthor);
            String actual = actualKeywords.Find(s => s == expectedKeyword);
            Assert.AreEqual(actualKeywords, expectedKeyword);
        }

        [TestMethod]
        public void FindAllNumericalAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor ="4526123456";
            Author a = new Author(expectedAuthor);
            String expectedKeyword = "Fusion";
            a.addKeyword(expectedKeyword);

            //Check if the author names match
            List<String> actualAuthorList = a.getAuthors();
            String actualAuthor = actualAuthorList.Find(s => s == expectedAuthor);
            Assert.AreEqual(actualAuthor, expectedAuthor);

            //Check if the keywords from the author match to the inputed keyword
            List<String> actualKeywords = a.getAuthorKeywords(expectedAuthor);
            String actual = actualKeywords.Find(s => s == expectedKeyword);
            Assert.AreEqual(actualKeywords, expectedKeyword);
        }

        [TestMethod]
        public void FindPartialUnicodeAuthor()
        {

            //Create a new author with a keyword
            String expectedAuthor ="Nürnberg";
            Author a = new Author(expectedAuthor);
            String expectedKeyword = "Mathematics";
            a.addKeyword(expectedKeyword);

            //Check if the author names match
            List<String> actualAuthorList = a.getAuthors();
            String actualAuthor = actualAuthorList.Find(s => s == expectedAuthor);
            Assert.AreEqual(actualAuthor, expectedAuthor);

            //Check if the keywords from the author match to the inputed keyword
            List<String> actualKeywords = a.getAuthorKeywords(expectedAuthor);
            String actual = actualKeywords.Find(s => s == expectedKeyword);
            Assert.AreEqual(actualKeywords, expectedKeyword);
        }

    [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException), "Author has no keywords")]
        public void FindNoKeywordAuthor()
        {

            //Create a new author with a keyword
            String expectedAuthor = "Nürnberg";
            Author a = new Author(expectedAuthor);

            //Check if the author names match
            List<String> actualAuthorList = a.getAuthors();
            String actualAuthor = actualAuthorList.Find(s => s == expectedAuthor);
            Assert.AreEqual(actualAuthor, expectedAuthor);

            //Returns an error of no keywords 
            List<String> nonexistingKeywords = a.getAuthorKeywords(expectedAuthor);
            Assert.AreEqual(nonexistingKeywords, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author does not exist")]
        public void FindNonExistingAuthor()
        {
            //Create a new author with a keyword
            String expectedAuthor = "John Smith";
            Author a = new Author(expectedAuthor);
            String expectedKeyword = "Fusion";
            a.addKeyword(expectedKeyword);

            //Check if the author names match
            List<String> actualAuthorList = a.getAuthors();
            String actualAuthor = actualAuthorList.Find(s => s == expectedAuthor);
            Assert.AreEqual(actualAuthor, expectedAuthor);

            //Raises an error if the author does not exist
            String nonExistingAuthor = "Mei Wang";
            String invalidAuthor = actualAuthorList.Find(s => s == nonExistingAuthor);
            Assert.AreEqual(invalidAuthor, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author name is invalid")]
        public void UnicodeAuthor()
        {
            //The input author is unicode symbols
            String unicodeAuthor = "╙φ¼╒≥│Θ╛╞";
            Author a = new Author(unicodeAuthor);

            List<String> keywords = a.listKeywords(unicodeAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author name is invalid")]
        public void NullAuthor()
        {
                //The input author is null
                String nullInputAuthor = null;
                Author a = new Author(nullInputAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text field is empty")]
        public void SpaceAuthor()
        {
            //The input Author is full if spaces
            String spaceInputAuthor = "               ";
            Author a = new Author(spaceInputAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text field is empty")]
        public void TabAuthor()
        {
            //The input author is full of tabs
            String tabInputAuthor = "                 ";
            Author a = new Author(tabInputAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text field is empty")]
        public void emptyAuthor()
        {
            //The input author is a empty string
            String emptyInputAuthor = "";
            Author a = new Author(emptyInputAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid author name")]
        public void invalidAuthor()
        {
            //The input author is a bunch of text symbols
            String emptyInputAuthor = "\t \n \t";
            Author a = new Author(emptyInputAuthor);
        }
    }
}
