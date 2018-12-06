using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class ParkModel
    {
        public string ParkCode { get; set; }
        public string ParkName { get; set; }
        public string State { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Acreage { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Elevation { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float MilesOfTrail { get; set; }
        public int NumberOfCampSites { get; set; }
        public string Climate { get; set; }
        public int YearFounded { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int AnnualVisitorCount { get; set; }
        public string InspirationalQuote { get; set; }
        public string InspirationalQuoteSource { get; set; }
        public string ParkDescription { get; set; }
        public int EntryFee { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int NumberOfAnimalSpecies { get; set; }

        public string TempSetter { get; set; }
    }
}
