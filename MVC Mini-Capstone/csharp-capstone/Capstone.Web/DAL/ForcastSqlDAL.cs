using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public class ForcastSqlDAL :IForcastDAL
    {
        private readonly string _connectionString;

        public ForcastSqlDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        private string SQL_ParkDetails = @"SELECT *, CAST(ROUND(((w.low-32)*(0.5556)),0)as INT)as CelciusLow, CAST(ROUND(((w.high-32)*(0.5556)),0)as INT) as CelciusHigh
                                            FROM park p, weather w
                                            WHERE p.parkCode=w.parkCode
                                            AND w.parkcode= @parkcode
                                            ";

        public IList<ForcastModel> GetForcast(string id)
        {
            IList<ForcastModel> forcast = new List<ForcastModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_ParkDetails, conn);
                cmd.Parameters.AddWithValue("@parkcode", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var forcasts = new ForcastModel
                    {
                        FiveDay = (int)reader["fivedayforecastvalue"],
                        Low = (int)reader["low"],
                        High = (int)reader["high"],
                        Forecast = (string)reader["forecast"],
                        CelciusLow = (int)reader["CelciusLow"],
                        CelciusHigh = (int)reader["CelciusHigh"]
                    };
                    forcast.Add(forcasts);
                }

            }
            return forcast;
        }

        
    }
}
