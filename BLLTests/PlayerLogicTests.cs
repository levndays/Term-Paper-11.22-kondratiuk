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
    public class PlayerLogicTests
    {
        [TestMethod()]
        public void AddPlayerTest()
        {
            // arrange
            DAL.Lists.InitializeObjects();
            Player TestPlayer = new Player("Test", "Test", DateTime.Now, "Доступний для гри", "Здоровий", 15000, "Захисник");

            // act
            BLL.PlayerLogic.AddPlayer(TestPlayer);

            // assert
            Assert.IsTrue(DAL.Lists.Players.Contains(TestPlayer)); // is object in list
        }

        [TestMethod()]
        public void ReplacePlayerTest()
        {
            // arrange
            DAL.Lists.InitializeObjects();
            Player TestPlayer = new Player("Test", "Test", DateTime.Now, "Доступний для гри", "Здоровий", 15000, "Захисник");
            Player SecondTestPlayer = new Player("Name", "Surname", DateTime.Now, "Доступний для гри", "Здоровий", 15000, "Захисник");
            BLL.PlayerLogic.AddPlayer(TestPlayer);


            // act
            BLL.PlayerLogic.ReplacePlayer(SecondTestPlayer, DAL.Lists.Players.IndexOf(TestPlayer));

            // assert
            Assert.IsTrue(!DAL.Lists.Players.Contains(TestPlayer) && DAL.Lists.Players.Contains(SecondTestPlayer));
        }

        [TestMethod()]
        public void FindPlayerTest()
        {
            // arrange
            DAL.Lists.InitializeObjects();
            Player TestPlayer = new Player("Test", "Testovich", DateTime.Now, "Доступний для гри", "Здоровий", 15000, "Захисник");
            BLL.PlayerLogic.AddPlayer(TestPlayer);

            // act
            var result = BLL.PlayerLogic.FindPlayer("Test");

            // assert
            Assert.IsTrue(result.Contains(TestPlayer));
        }
    }
}