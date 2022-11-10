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
    public class StadiumLogicTests
    {
        [TestMethod()]
        public void ReplaceStadiumTest()
        {
            // arrange
            DAL.Lists.InitializeObjects();
            Stadium TestStadium = new("Test Arena", 5000, 50, new List<string>());

            // act
            BLL.StadiumLogic.AddStadium(TestStadium);

            // assert
            Assert.IsTrue(DAL.Lists.Stadiums.Contains(TestStadium)); // is object in list
        }

        [TestMethod()]
        public void ReplaceStadiumTest1()
        {
            // arrange
            DAL.Lists.InitializeObjects();
            Stadium TestStadium = new("Test Arena", 5000, 50, new List<string>());
            Stadium SecondTestStadium = new("Test Arena 2", 5500, 50, new List<string>());
            BLL.StadiumLogic.AddStadium(TestStadium);


            // act
            BLL.StadiumLogic.ReplaceStadium(SecondTestStadium, DAL.Lists.Stadiums.IndexOf(TestStadium));

            // assert
            Assert.IsTrue(!DAL.Lists.Stadiums.Contains(TestStadium) && DAL.Lists.Stadiums.Contains(SecondTestStadium));
        }
    }
}