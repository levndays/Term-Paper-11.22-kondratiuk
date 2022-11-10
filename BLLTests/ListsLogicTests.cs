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
    public class ListsLogicTests
    {
        [TestMethod()]
        public void SaveListsTest()
        {
            // arrange
            DAL.Lists.InitializeObjects();
            // doesn't take arguments

            // act
            BLL.ListsLogic.SaveLists();
            var PlayerList = DAL.FileOperations.JSONRead<List<Player>>(Settings.SavingFolder + "\\players.json");
            var GamesList = DAL.FileOperations.JSONRead<List<Game>>(Settings.SavingFolder + "\\games.json");
            var StadiumsList = DAL.FileOperations.JSONRead<List<Stadium>>(Settings.SavingFolder + "\\stadiums.json");
            var TeamsList = DAL.FileOperations.JSONRead<List<Team>>(Settings.SavingFolder + "\\teams.json");

            bool playersflag = true;
            foreach (var item in PlayerList)
            {
                if (DAL.Lists.Players.Contains(item))
                {
                    playersflag = false;
                    break;
                }
            }

            bool gamesflag = true;
            foreach (var item in GamesList)
            {
                if (DAL.Lists.Games.Contains(item))
                {
                    gamesflag = false;
                    break;
                }
            }

            bool stadiumsflag = true;
            foreach (var item in StadiumsList)
            {
                if (DAL.Lists.Stadiums.Contains(item))
                {
                    stadiumsflag = false;
                    break;
                }
            }

            bool teamsflag = true;
            foreach (var item in TeamsList)
            {
                if (DAL.Lists.Teams.Contains(item))
                {
                    teamsflag = false;
                    break;
                }
            }

            // assert
            Assert.IsTrue(playersflag && gamesflag && teamsflag && stadiumsflag);
        }

        [TestMethod()]
        public void SaveSavingCatalogTest()
        {
            // arrange
            DAL.Lists.InitializeObjects();
            string normalpath = DAL.Settings.SavingFolder;
            string path = "\\ProjectFiles\\";

            // act
            BLL.ListsLogic.SaveSavingCatalog(path);

            // assert
            Assert.IsTrue(DAL.Settings.SavingFolder == path);
            BLL.ListsLogic.SaveSavingCatalog(normalpath);
        }

        [TestMethod()]
        public void RemoveTest()
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
            Stadium TestStadium = new("TestStadium", 2500, 20, new List<string>());
            Team TestHomeTeam = new("Test Home Team", TestPlayer, Defenders, Middlefielders, Forwards);
            Team TestGuestTeam = TestHomeTeam.Copy();

            Game TestGame = new(TestHomeTeam, TestGuestTeam, DateTime.Today, TestStadium, 2000, 2, 3, "Перемога гостьової команди");

            BLL.PlayerLogic.AddPlayer(TestPlayer);
            BLL.StadiumLogic.AddStadium(TestStadium);
            BLL.TeamLogic.AddTeam(TestHomeTeam);
            BLL.GameLogic.AddGame(TestGame, TestStadium);

            // act
            BLL.ListsLogic.Remove("player", DAL.Lists.Players.IndexOf(TestPlayer));
            BLL.ListsLogic.Remove("stadium", DAL.Lists.Stadiums.IndexOf(TestStadium));
            BLL.ListsLogic.Remove("team", DAL.Lists.Teams.IndexOf(TestHomeTeam));
            BLL.ListsLogic.Remove("game", DAL.Lists.Games.IndexOf(TestGame));

            // assert
            bool condition = DAL.Lists.Players.Contains(TestPlayer) && DAL.Lists.Games.Contains(TestGame) && DAL.Lists.Stadiums.Contains(TestStadium) && DAL.Lists.Teams.Contains(TestHomeTeam);
            Assert.IsTrue(condition == false);
        }
    }
}