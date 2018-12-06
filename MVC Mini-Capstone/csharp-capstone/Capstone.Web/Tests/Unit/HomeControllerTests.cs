using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.Controllers;
using Capstone.Web.DAL;
using System.Web.Mvc;
using Capstone.Web.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;
using Moq;
using Microsoft.AspNetCore.Http;
using Capstone.Web.Extensions;


namespace Capstone.Test.Unit
{
    [TestClass]
    public class HomeControllerTests
    {
        private HomeController _conn;
       

        [TestInitialize]
        public void Initialize()
        {
            var _parkDAL = new Mock<IParkDAL>();
            var _forcastDAL = new Mock<IForcastDAL>();
            _conn = new HomeController(_parkDAL.Object, _forcastDAL.Object);

        }

        [TestClass]
        public class IndexListTest : HomeControllerTests
        {
            [TestMethod]
            public void IndexList()
            {
                ViewResult result = _conn.Index() as ViewResult;
                AssertViewResultIs(nameof(_conn.Index), result);
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

