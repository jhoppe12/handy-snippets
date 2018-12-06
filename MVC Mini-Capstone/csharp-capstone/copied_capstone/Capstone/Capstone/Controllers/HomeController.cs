using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;
using Capstone.Web.Extensions;
using System.Web;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IParkDAL _parkDAL;
        private readonly IForcastDAL _forDAL;
        

        public HomeController(IParkDAL parkDAL, IForcastDAL forDAL)
        {
            _parkDAL = parkDAL;
            _forDAL = forDAL;
            
        }

        public ActionResult Index()
        {
            
            IList<ParkModel> parks = _parkDAL.GetParks();
            return View(parks);
        }

        public IActionResult Detail(string id, string tempsetter)
        {
            if (id != null)
            {
                HttpContext.Session.SetString("id", id);
            }
            else
            {
               id= HttpContext.Session.GetString("id");
            }
            string tempType = HttpContext.Session.GetString("temp"); 
            if (tempType ==null || tempType.Contains("F"))
                {
                tempType ="F";
                HttpContext.Session.SetString("temp", tempType);
            }
            else
            {
                tempType = "C";
                HttpContext.Session.SetString("temp", tempType);
            }

           
            ParkDetailViewModel parkdetail = new ParkDetailViewModel
            {
                Id = id,
                GetParks = _parkDAL.GetParks(HttpContext.Session.GetString("id")),
                GetForcast = _forDAL.GetForcast(HttpContext.Session.GetString("id")),
                TempSetter = tempType
            };
                return View(parkdetail);
        }

        
        public void SaveTemp(string tempsetter, string id)
        {
            
            SaveSession(tempsetter, id);
            Response.Redirect("Detail/" + id);

        }

        private void SaveSession(string tempsetter, string id)// <-- saves  into session
        {
            HttpContext.Session.Set("temp", tempsetter);
           // HttpContext.Session.Set("id", id);
            ParkDetailViewModel parkdetail = new ParkDetailViewModel
            {
                //GetParks = _parkDAL.GetParks(id),
                //GetForcast = _forDAL.GetForcast(id),
                TempSetter = HttpContext.Session.Get<string>("temp")
            };
            Redirect("Detail");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
    }
}
