using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repo
{
    public class TeamRepository
    {
        //After this is set up, Komodo will need a Repository that will have the ability to:
        //Hold all of the existing Teams - repository
        protected readonly List<Team> _teamDirectory = new List<Team>();

        //Have the ability to create new teams - add teams

        public bool AddTeamToDirectory(Team team)
        {
            int directoryLength = _teamDirectory.Count();
            _teamDirectory.Add(team);
            bool wasAdded = directoryLength + 1 == _teamDirectory.Count();
            return wasAdded;
        }
        //Get a team by its ID - read teams

        public Team GetTeamById(int teamId)
        {
            foreach (Team team in _teamDirectory)
            {
                if(team.TeamId == teamId)
                {
                    return team;
                }
            }
            return null;
        }
        //Delete a team by its ID - delete teams
        public bool DeleteTeamById(int teamId)
        {
            Team foundTeam = GetTeamById(teamId);
            bool deletedResult = _teamDirectory.Remove(foundTeam);
            return deletedResult;
        }
    }
}
