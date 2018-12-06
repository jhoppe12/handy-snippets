using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Web.Models;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using Capstone.Web.DAL;


namespace Capstone.Test.Integration
{
    [TestClass()]
    public class ParkDALTests : AllDALTestSetup
    {
        [TestMethod()]
        public void GetParksTest()
        {
            // Arrange 
            IParkDAL pDAL = new ParkSqlDAL(connectionString);

            //Act
            IList<ParkModel> park = pDAL.GetParks();

            //Assert
            int parkTotal = park.Count;
            Assert.IsNotNull(park);
            Assert.AreEqual(4, parkTotal);
        }

        [TestMethod()]
        public void GetParkDetailTest()
        {
            //Arrange
            IParkDAL pDetailDAL = new ParkSqlDAL(connectionString);

            //Act
            IList<ParkModel> details = pDetailDAL.GetParks("YNP");

            //Assert
            Assert.IsNotNull(details);
            Assert.AreEqual("Yellowstone National Park", details[0].ParkName);
        }
    }
}
