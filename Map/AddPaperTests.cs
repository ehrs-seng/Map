using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Map
{
    [TestClass]
    public class AddPaperTests
    {
        //add title tests
        [TestMethod]
        public void AddNormalTitle()
        {
            String title = "Testing";
            Paper newpaper = new Paper();
            newpaper.setTitle(title);

            Assert.AreEqual(title, newpaper.getTitle());
        }

        [TestMethod]
        public void AddAlphanumericTitle()
        {
            String title = "Test1234";
            Paper newpaper = new Paper();
            newpaper.setTitle(title);

            Assert.AreEqual(title, newpaper.getTitle());

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Title must not be an empty string")]
        public void AddEmptyStringTitle()
        {
            String title = "";
            Paper newpaper = new Paper();
            newpaper.setTitle(title);

            Assert.AreEqual(title, newpaper.getTitle());
        }

        [TestMethod]
        public void AddNumericalTitle() //assuming papers can have titles of only numbers, similiar to book "1984"
        {
            String title = "1234";
            Paper newpaper = new Paper();
            newpaper.setTitle(title);

            Assert.AreEqual(title, newpaper.getTitle());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Title must not be a null value")]
        public void AddNullStringTitle()
        {
            String title = null;
            Paper newpaper = new Paper();
            newpaper.setTitle(title);

            Assert.AreEqual(title, newpaper.getTitle());
        }

        //add author tests
        [TestMethod]
        public void AddNormalAuthor()
        {
            String author = "Testing";
            Paper newpaper = new Paper();
            newpaper.setAuthor(author);

            Assert.IsTrue(newpaper.getAuthor().Contains(author));
        }

        [TestMethod]
        public void AddAlphanumericAuthor()
        {
            String author = "Test1234";
            Paper newpaper = new Paper();
            newpaper.setAuthor(author);

            Assert.IsTrue(newpaper.getAuthor().Contains(author));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author must not be an empty string")]
        public void AddEmptyStringAuthor()
        {
            String author = "";
            Paper newpaper = new Paper();
            newpaper.setAuthor(author);

            Assert.IsTrue(newpaper.getAuthor().Contains(author));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Author must contain letters")]   
        public void AddAuthorNumericalAuthor()
        {
            String author = "1234";
            Paper newpaper = new Paper();
            newpaper.setAuthor(author);

            Assert.IsTrue(newpaper.getAuthor().Contains(author));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Author must not be a null value")]
        public void AddAuthorNullStringAuthor()
        {
            String author = null;
            Paper newpaper = new Paper();
            newpaper.setAuthor(author);

            Assert.IsTrue(newpaper.getAuthor().Contains(author));
        }

        //add year tests
        [TestMethod]
        public void AddNormalYear()
        {
            int year = 1234;
            Paper newpaper = new Paper();
            newpaper.setYear(year);

            Assert.AreEqual(year, newpaper.getYear());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Year must not be negative")]
        public void AddNegativeYear()
        {
            int year = -1234;
            Paper newpaper = new Paper();
            newpaper.setYear(year);

            Assert.AreEqual(year, newpaper.getYear());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Year should not contain more than four digits")]
        public void AddMoreThanFourDigitYear()
        {
            int year = 12345;
            Paper newpaper = new Paper();
            newpaper.setYear(year);

            Assert.AreEqual(year, newpaper.getYear());
        }

        //skipping test for alphanumeric, due to typecasting of int

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Year should not be zero")]
        public void AddZeroYear()
        {
            int year = 0;
            Paper newpaper = new Paper();
            newpaper.setYear(year);

            Assert.AreEqual(year, newpaper.getYear());
        }

        
        //add abstract tests
        [TestMethod]
        public void AddNormalAbstract()
        {
            String abstracttext = "Testing";
            Paper newpaper = new Paper();
            newpaper.setAbstract(abstracttext);

            Assert.AreEqual(abstracttext, newpaper.getAbstract());
        }

        [TestMethod]
        public void AddAlphanumericAbstract()
        {
            String abstracttext = "Test1234";
            Paper newpaper = new Paper();
            newpaper.setAbstract(abstracttext);

            Assert.AreEqual(abstracttext, newpaper.getAbstract());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Abstract must not be an empty string")]
        public void AddEmptyStringAbstract()
        {
            String abstracttext = "";
            Paper newpaper = new Paper();
            newpaper.setAbstract(abstracttext);

            Assert.AreEqual(abstracttext, newpaper.getAbstract());
        }

        [TestMethod]
        public void AddNumericalAbstract()
        {
            String abstracttext = "1234";
            Paper newpaper = new Paper();
            newpaper.setAbstract(abstracttext);

            Assert.AreEqual(abstracttext, newpaper.getAbstract());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Abstract must not be a null value")]
        public void AddNullAbstract()
        {
            String abstracttext = null;
            Paper newpaper = new Paper();
            newpaper.setAbstract(abstracttext);

            Assert.AreEqual(abstracttext, newpaper.getAbstract());
        }
    }





}
