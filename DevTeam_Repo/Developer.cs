using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repo
{
    public class Developer
    {
        //The Developer objects - class 
            //have an ID - property int
            public int DeveloperId { get; set; }
        //a last name, - property string
        public string LastName { get; set; }
        // and whether or not they have access to a Pluralsight account - property bool
        public bool HasPluralsightAccess { get; set; }

       public Developer() { }
        public Developer(int developerId, string lastName, bool hasPluralsightAccess)
        {
            DeveloperId = developerId;
            LastName = lastName;
            HasPluralsightAccess = hasPluralsightAccess;
        }

    }
}
