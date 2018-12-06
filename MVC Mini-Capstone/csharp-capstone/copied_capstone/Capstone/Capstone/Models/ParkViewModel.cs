using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class ParkViewModel
    {
       
        public IList<ParkModel> GetParks { get; set; }
        public string TempSetter { get; set; }
    }
}
