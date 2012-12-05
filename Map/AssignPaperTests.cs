using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Map
{
    [TestClass]
    public class AssignPaperTests
    {
        [TestMethod]
        public void NewPI()
        {
            PrincipalInvestigator somePI = new PrincipalInvestigator("John", "Smith");
            Assert.AreEqual("John Smith", somePI.getName());
        }

        [TestMethod]
        public void NewRA()
        {
            ResearchAssistant someRA = new ResearchAssistant("Mary", "Smith");
            Assert.AreEqual(someRA.getName(), "Mary Smith");
        }

        [TestMethod]
        public void AddRA()
        {
            ResearchAssistant someRA = new ResearchAssistant();
            PrincipalInvestigator somePI = new PrincipalInvestigator();

            somePI.addResearchAssistant(someRA);
            Assert.IsTrue(somePI.getResearchAssistants().Contains(someRA));
        }

        [TestMethod]
        public void AddNullRA()
        {
            ResearchAssistant someRA = null;
            PrincipalInvestigator somePI = new PrincipalInvestigator();

            somePI.addResearchAssistant(someRA);
            Assert.IsFalse(somePI.getResearchAssistants().Contains(someRA));
        }

        [TestMethod]
        public void AddDuplicateRA()
        {
            ResearchAssistant someRA = new ResearchAssistant();
            PrincipalInvestigator somePI = new PrincipalInvestigator();

            somePI.addResearchAssistant(someRA);
            somePI.addResearchAssistant(someRA);
            Assert.IsTrue(somePI.getResearchAssistants().Count() == 1);
        }

        [TestMethod]
        public void AssignPaper()
        {
            ResearchAssistant someRA = new ResearchAssistant();
            PrincipalInvestigator somePI = new PrincipalInvestigator();
            Paper somePaper = new Paper();

            somePI.addResearchAssistant(someRA);
            somePI.assignPaperToKeywordToResearchAssistant(somePaper, someRA);
            Assert.IsTrue(someRA.getPapersToKeyword().Contains(somePaper));
        }

        [TestMethod]
        public void AssignNullPaper()
        {
            ResearchAssistant someRA = new ResearchAssistant();
            PrincipalInvestigator somePI = new PrincipalInvestigator();
            Paper somePaper = null;

            somePI.addResearchAssistant(someRA);
            somePI.assignPaperToKeywordToResearchAssistant(somePaper, someRA);
            Assert.IsTrue(someRA.getPapersToKeyword() == null);
        }

        [TestMethod]
        public void AssignDuplicatePaper()
        {
            ResearchAssistant someRA = new ResearchAssistant();
            PrincipalInvestigator somePI = new PrincipalInvestigator();
            Paper somePaper = new Paper();

            somePI.addResearchAssistant(someRA);
            somePI.assignPaperToKeywordToResearchAssistant(somePaper, someRA);
            somePI.assignPaperToKeywordToResearchAssistant(somePaper, someRA);
            Assert.IsTrue(someRA.getPapersToKeyword().Count() == 1);
        }
    }
}