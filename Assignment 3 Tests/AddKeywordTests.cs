using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Map
{
    [TestClass]
    public class AddKeywordTests
    {
        [TestMethod]
        public void AddNormalUniqueKeyword()
        {   
            String expectedkeyword = "Testing";
            Paper existingpaper = new Paper();
            Author a = new Author();

            existingpaper.addKeyword(expectedkeyword);
            List<String> keywords = existingpaper.listKeywords();
            List<String> authorkeywords = a.listKeywords();

            String actual = keywords.Find(s => s == expectedkeyword);
            Assert.AreEqual(actual, expectedkeyword);

            actual = authorkeywords.Find(s => s == expectedkeyword);
            Assert.AreEqual(actual, expectedkeyword);

        }

        [TestMethod]
        public void RemoveNormalUniqueKeyword()
        {
            String expectedkeyword = "Testing";
            Paper existingpaper = new Paper();
            Author a = new Author();

            existingpaper.removeKeyword(expectedkeyword);
            List<String> keywords = existingpaper.listKeywords();

            bool removed = keywords.Contains(expectedkeyword);
            Assert.IsFalse(removed);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "No duplicate keywords allowed.")]
        public void AddDuplicateKeyword()
        {
            String expectedkeyword = "Testing";
            Paper existingpaper = new Paper();

            existingpaper.addKeyword(expectedkeyword);
            existingpaper.addKeyword(expectedkeyword);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Keywords must not be an empty string")]
        public void AddEmptyStringKeyword()
        {
            String expectedkeyword = "";
            Paper existingpaper = new Paper();

            existingpaper.addKeyword(expectedkeyword);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Keywords must contain letters")]
        public void AddNumericalKeyword()
        {
            String expectedkeyword = "1234";
            Paper existingpaper = new Paper();

            existingpaper.addKeyword(expectedkeyword);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Keywords must not be a null value")]
        public void AddNullStringKeyword()
        {
            String expectedkeyword = null;
            Paper existingpaper = new Paper();

            existingpaper.addKeyword(expectedkeyword);
        }
    }
}
