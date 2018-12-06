using Capstone.Web.Controllers;
using Capstone.Web.DAL;
using Capstone.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;
using Moq;

namespace Capstone.Test.Unit
{
    [TestClass]
    public class SurveyControllerTests
    {
        private SurveyController _conn;
       
        [TestInitialize]
        public void Initialize()
        {
            var _survDAL = new Mock<ISurveyDAL>();
             _conn = new SurveyController(_survDAL.Object);
            
        }

        [TestClass]
        public class AllSurveys : SurveyControllerTests
        {
            [TestMethod]
            public void AllSurveyView()
            {             
                ViewResult result = _conn.SubmitSurvey() as ViewResult;
                AssertViewResultIs(nameof(_conn.SubmitSurvey), result);
            }
        }

        [TestClass]
        public class New_SURVEY : SurveyControllerTests
        {
            [TestMethod]
            public void NewPost()
            {
                ActionContext actionContext = new ActionContext();
                var result = _conn.SubmitSurvey() as ViewResult;
                AssertViewResultIs(nameof(_conn.SubmitSurvey), result);
            }
        }

        protected void AssertViewResultIs(string action, ViewResult viewResult)
        {
            Assert.IsTrue(viewResult.ViewName == null ||
                viewResult.ViewName.Equals(action, StringComparison.InvariantCultureIgnoreCase),
                $"Result.ViewName was {viewResult.ViewName}, but expected null or {action}.");
        }
    }
}

