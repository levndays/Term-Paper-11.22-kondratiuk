using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL.Tests
{
    [TestClass()]
    public class TeamLogicTests
    {
        [TestMethod()]
        public void ReplaceTeamTest()
        {
            // arrange
            DAL.Lists.InitializeObjects();

            Player TestPlayer = new Player("Test", "Test", DateTime.Now, "Доступний для гри", "Здоровий", 15000, "Воротар");
            List<Player> Defenders = new List<Player>();
            List<Player> Middlefielders = new List<Player>();
            List<Player> Forwards = new List<Player>();
            for (int i = 0; i < 4; i++)
            {
                Defenders.Add(new("Test", "Player", DateTime.Now, "Доступний для гри", "Здоровий", 15000, "Захисник"));
            }
            for (int i = 0; i < 3; i++)
            {
                Middlefielders.Add(new("Test", "Player", DateTime.Now, "Доступний для гри", "Здоровий", 15000, "Півзахисник"));
            }
            for (int i = 0; i < 3; i++)
            {
                Forwards.Add(new("Test", "Player", DateTime.Now, "Доступний для гри", "Здоровий", 15000, "Форвард"));
            }
            Team TestHomeTeam = new("Test Home Team", TestPlayer, Defenders, Middlefielders, Forwards);
            Team SecondHomeTeam = TestHomeTeam.Copy();

            BLL.TeamLogic.AddTeam(TestHomeTeam);

            // act
            BLL.TeamLogic.ReplaceTeam(SecondHomeTeam, DAL.Lists.Teams.IndexOf(TestHomeTeam));

            // assert
            Assert.IsTrue(!DAL.Lists.Teams.Contains(TestHomeTeam) && DAL.Lists.Teams.Contains(SecondHomeTeam));
        }
    }
}