using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class SurveyModel
    {
     
        [Required]
        [Display(Name="Park")]
        public string ParkCode { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [Display(Name ="What's your activity level?")]
        public string ActivityLevel { get; set; }
        public string ParkName { get; set; }
        public int ParkCount { get; set; }

       
        public IList<SurveyModel> DisplaySurveys { get; set; }

        public static List<SelectListItem> nationalParks = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Cuyahoga Valley National Park", Value="CVNP" },
            new SelectListItem() { Text = "Everglades National Park", Value = "ENP" },
            new SelectListItem() { Text = "Grand Canyon National Park", Value = "GCNP" },
            new SelectListItem() { Text = "Glacier National Park", Value = "GNP" },
            new SelectListItem() { Text = "Great Smoky Mountains National Park", Value = "GSMNP" },
            new SelectListItem() { Text = "Grand Teton National Park", Value = "GTNP" },
            new SelectListItem() { Text = "Mount Rainier National Park", Value = "MRNP" },
            new SelectListItem() { Text = "Rocky Mountain National Park", Value = "RMNP" },
            new SelectListItem() { Text = "Yellowstone National Park", Value = "YNP" },
            new SelectListItem() { Text = "Yosemite National Park", Value = "YNP2" },
        };
    }
}
