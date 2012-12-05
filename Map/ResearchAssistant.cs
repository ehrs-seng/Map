using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class ResearchAssistant
    {
        protected string firstName;
        protected string lastName;

        // this research assistant's assigned papers to add keywords to
        private List<Paper> assignedPapersToKeyword;

        public ResearchAssistant()
        {
            firstName = "";
            lastName = "";
            assignedPapersToKeyword = new List<Paper>();
        }

        public ResearchAssistant(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
            assignedPapersToKeyword = new List<Paper>();
        }

        public string getName()
        {
            // return this research assistant's name
            return (firstName + " " + lastName);
        }

        public List<Paper> getPapersToKeyword()
        {
            // if list is empty, return null
            if (assignedPapersToKeyword.Count <= 0) return null;

            // return this research assistant's assigned papers to keyword
            return assignedPapersToKeyword;
        }

        public void addPaperToKeyword(Paper p)
        {
            // if argument is null, return
            if (p == null) return;

            // if this research assistant's assigned papers to keyword doesn't contain p, add it
            if (assignedPapersToKeyword.Contains(p) == false)
                assignedPapersToKeyword.Add(p);
        }
    }
}
