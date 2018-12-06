using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Web.DAL;
using Capstone.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Capstone.Web.Controllers
{
    public class SurveyController : Controller
    {
        private const string NewPostResultKey = nameof(NewPostResultKey);
        private readonly ISurveyDAL _survDAL;
        private Mock<ISurveyDAL> _survDAL1;

        public SurveyController(ISurveyDAL servDAL)
        {
            _survDAL = servDAL;
        }


        public IActionResult Index()
        {
           IList<SurveyModel> DisplaySurveys = _survDAL.DisplaySurveys();
           return View(DisplaySurveys);
        }


        [HttpGet]
        public IActionResult SubmitSurvey()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitSurvey(SurveyModel model)
        {
            if (!ModelState.IsValid)
            {

                return View(model);
            }
            else
            {
                _survDAL.AddNewSurvey(model);
                //TempData["msg"] = "<button><strong> Your Survey has been Added! See the new park rankings!</strong></button>";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}