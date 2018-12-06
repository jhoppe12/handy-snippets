using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class ParkDetailViewModel
    {

        //public IList<ForcastModel> Get_C_Forcast { get; set; }
        public IList<ForcastModel> GetForcast { get; set; }
        public IList<ParkModel> GetParks { get; set; }

        [Display(Name = "Weather Metric")]
        public string TempSetter { get; set; }
        public string Id { get; set; }

    }
}
