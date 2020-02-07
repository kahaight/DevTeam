using System;
using System.Collections.Generic;
using DevTeam_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevTeam_RepoTests
{
    [TestClass]
    public class TeamRepositoryTests
    {

        private TeamRepository _repo;
        private Team _team;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new TeamRepository();
            _team = new Team(new List<Developer>(), "Blue", 1);
            _repo.AddTeamToDirectory(_team);
            _team = new Team(new List<Developer>(), "Red", 2);
            _repo.AddTeamToDirectory(_team);
            _team = new Team(new List<Developer>(), "Green", 3);
            _repo.AddTeamToDirectory(_team);
        }
        [TestMethod]
        public void AddTeamToDirector()
        {
            Team team = new Team();
            TeamRepository teamRepository = new TeamRepository();
            bool wasAdded = teamRepository.AddTeamToDirectory(team);
            Assert.IsTrue(wasAdded);
            
        }

        [TestMethod]
        public void GetTeamById_()
        {
            Team team = new Team();
            team = _repo.GetTeamById(1);
            string actual = team.TeamName;
            string expected = "Blue";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteTeamById()
        {
            bool wasRemoved = _repo.DeleteTeamById(1);
            Assert.IsTrue(wasRemoved);
        }


    }
}
