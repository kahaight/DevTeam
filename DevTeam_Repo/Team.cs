using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repo
{
    public class Team
    {//Team class that allows us to - Class
     //hold the list of Developers on that team - Property List
        public List<Developer> Developers { get; set; }
        //along with the team's name and ID. - Property string and int
        public string TeamName { get; set; }
        public int TeamId { get; set; }
        public Team() 
        {
            Developers = new List<Developer>();
        }
        public Team(List<Developer> developers, string teamName, int teamId)
        {
            Developers = developers;
            TeamName = teamName;
            TeamId = teamId;
        }

        //The Team should be able to 
        //add new members and - team Methods
        public bool AddNewMembers(Developer developer)
        {
            int listLength = Developers.Count();
            Developers.Add(developer);
            bool wasAdded = listLength + 1 == Developers.Count();
            return wasAdded;
        }
        //remove members by their ID - team Methods
        public Developer GetMemberByTeamId(int teamId)
        {
            foreach (Developer developer in Developers)
            {
                if (developer.DeveloperId == teamId)
                {
                    return developer;
                }
            }
            return null;
            
        }
        public bool RemoveMemberById(int teamId)
        {
            Developer developer = GetMemberByTeamId(teamId);
            bool memberIsDeleted = Developers.Remove(developer);
            return memberIsDeleted;
        }
    }
}
