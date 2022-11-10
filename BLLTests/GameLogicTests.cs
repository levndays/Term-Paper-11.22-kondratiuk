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
    public class GameLogicTests
    {
        [TestMethod()]
        public void AddGameTest()
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


            // act
            BLL.GameLogic.AddGame(TestGame, TestStadium);

            // assert
            Assert.IsTrue(DAL.Lists.Games.Contains(TestGame)); // is object in list
        }

        [TestMethod()]
        public void ReplaceGameTest()
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
            Game SecondTestGame = TestGame.Copy();

            BLL.GameLogic.AddGame(TestGame, TestStadium);

            // act
            BLL.GameLogic.ReplaceGame(SecondTestGame, TestStadium, DAL.Lists.Games.IndexOf(TestGame));

            // assert
            Assert.IsTrue(!DAL.Lists.Games.Contains(TestGame) && DAL.Lists.Games.Contains(SecondTestGame));
        }
    }
}