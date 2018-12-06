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
    public class SurveyDALTests : AllDALTestSetup
    {
        [TestMethod()]
        public void DisplaySurveys()
        {
            // Arrange 
            ISurveyDAL sDAL = new SurveySqlDAL(connectionString);

            //Act
            IList<SurveyModel> survey = sDAL.DisplaySurveys();

            //Assert
            int surveyTotal = survey.Count;
            Assert.IsNotNull(survey);
            Assert.AreEqual(3, surveyTotal);
        }
    }
}
