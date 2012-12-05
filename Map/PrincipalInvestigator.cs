using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class PrincipalInvestigator : ResearchAssistant
    {
        // list of this principal investigator's research assistants
        private List<ResearchAssistant> myResearchAssistants;

        public PrincipalInvestigator()
        {
            firstName = "";
            lastName = "";

            myResearchAssistants = new List<ResearchAssistant>();
        }

        public PrincipalInvestigator(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;

            myResearchAssistants = new List<ResearchAssistant>();
        }

        public string getName()
        {
            // return principal investigator's name
            return (firstName + " " + lastName);
        }

        public void addResearchAssistant(ResearchAssistant ra)
        {
            // if argument null, return
            if (ra == null) return;

            // if argument ra not already in my research assistants, add
            if (myResearchAssistants.Contains(ra) == false)
                myResearchAssistants.Add(ra);
        }

        public List<ResearchAssistant> getResearchAssistants()
        {
            // return my research assistants
            return myResearchAssistants;
        }

        public void assignPaperToKeywordToResearchAssistant(Paper p, ResearchAssistant ra)
        {
            // if arguments are null, return
            if (p == null) return;
            if (ra == null) return;

            // if argument's research assistant is not this principal investigator's
            // research assistant, return
            if (myResearchAssistants.Contains(ra) == false) return;

            // add p to ra's assigned papers to keyword
            ra.addPaperToKeyword(p);
        }
    }
}
