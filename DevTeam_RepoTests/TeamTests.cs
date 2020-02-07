using System;
using System.Collections.Generic;
using DevTeam_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevTeam_RepoTests
{
    [TestClass]
    public class TeamTests
    {
        
        [TestMethod]
        public void AddNewMembers_ShouldReturnTrue()
        {
            Team team = new Team();
            Developer developer = new Developer(1, "Haight", true);
            bool addMember = team.AddNewMembers(developer);
            Assert.IsTrue(addMember);
                       
        }
        [TestMethod]
        public void RemoveMembers_ShouldReturnTrue()
        {
            Team team = new Team();
            Developer developer = new Developer(1, "haight", true);
            team.AddNewMembers(developer);
            int teamId = developer.DeveloperId;
            bool isRemoved = team.RemoveMemberById(teamId);
            Assert.IsTrue(isRemoved);

        }
    }
}
