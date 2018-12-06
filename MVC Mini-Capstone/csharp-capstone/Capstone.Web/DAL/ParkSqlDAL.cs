using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
    public class ParkSqlDAL : IParkDAL
    {
        private string SQL_ParkDetails = @"SELECT * 
                                           FROM park
                                            ";

        private readonly string _connectionString;

        public ParkSqlDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<ParkModel> GetParks(string id)
        {
            IList<ParkModel> park = new List<ParkModel>();
             park.Add(GetParks().FirstOrDefault(r => r.ParkCode == id));
            return park;
        }

        public IList<ParkModel> GetParks()
        {
            IList<ParkModel> parks = new List<ParkModel>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_ParkDetails, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var park = new ParkModel
                    {
                        ParkCode = (string)reader["ParkCode"],
                        ParkName = (string)reader["ParkName"],
                        State = (string)reader["State"],
                        Acreage = (int)reader["Acreage"],
                        Elevation = (int)reader["ElevationInFeet"],
                        MilesOfTrail = (float)reader["MilesOfTrail"],
                        NumberOfCampSites = (int)reader["NumberOfCampSites"],
                        Climate = (string)reader["Climate"],
                        YearFounded = (int)reader["YearFounded"],
                        AnnualVisitorCount = (int)reader["AnnualVisitorCount"],
                        InspirationalQuote = (string)reader["InspirationalQuote"],
                        InspirationalQuoteSource = (string)reader["InspirationalQuoteSource"],
                        ParkDescription = (string)reader["ParkDescription"],
                        EntryFee = (int)reader["EntryFee"],
                        NumberOfAnimalSpecies = (int)reader["NumberOfAnimalSpecies"]
                    };
                    parks.Add(park);
                }
            }
            return parks;
        }

       
    }
}


