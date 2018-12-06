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
    public class WeatherDALTests : AllDALTestSetup
    {
        [TestMethod()]
        public void GetWeatherTest()
        {
            // Arrange 
            IForcastDAL wDAL = new ForcastSqlDAL(connectionString);

            //Act
            IList<ForcastModel> weather = wDAL.GetForcast("CVNP");

            //Assert
            Assert.IsNotNull(weather);
            Assert.AreEqual(5, weather.Count);
        }
    }
}

