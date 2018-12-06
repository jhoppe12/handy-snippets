using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public class SurveySqlDAL :ISurveyDAL

    {
        private readonly string _connectionString;

        public SurveySqlDAL(string connectionString)
        {
            _connectionString = connectionString;
        }
       
        private string SQL_DisplaySurveys = @"SELECT p.parkName, p.parkCode, COUNT(s.surveyId) AS TotalParkVotes 
                                                FROM survey_result s, park p
                                                WHERE s.parkCode = p.parkCode
                                                GROUP BY p.parkName, p.parkCode
                                                HAVING COUNT(s.surveyId)>=1
                                                ORDER BY TotalParkVotes DESC, p.parkName";

        private string SQL_AddNewSurvey = @"INSERT INTO [dbo].[survey_result]
                                           ([parkCode]
                                           ,[emailAddress]
                                           ,[state]
                                           ,[activityLevel])
                                     VALUES
                                           (@parkCode
                                           ,@email
                                           ,@state
                                           ,@activity)";
        private string SQL_DisplayParkChoices = @"SELECT parkCode, parkName FROM park";

      

        public IList<SurveyModel> DisplaySurveys()
        {
            IList<SurveyModel> surveys = new List<SurveyModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_DisplaySurveys, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var surv = new SurveyModel
                    {
                        ParkCode = (string)reader["parkCode"],
                        ParkName = (string)reader["parkname"],
                        ParkCount = (int)reader["TotalParkVotes"]
                    };
                    surveys.Add(surv);
                }
            }

            return surveys;
        }

        public bool AddNewSurvey(SurveyModel survey)
        {
            bool added = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(SQL_AddNewSurvey, conn))
                    {
                        cmd.Parameters.AddWithValue("@parkCode", survey.ParkCode);
                        cmd.Parameters.AddWithValue("@email", survey.Email);
                        cmd.Parameters.AddWithValue("@state", survey.State);
                        cmd.Parameters.AddWithValue("@activity", survey.ActivityLevel);
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            added = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return added;
        }

        public IList<SurveyModel> ParkPicks()
        {
            IList<SurveyModel> allparks = new List<SurveyModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_DisplayParkChoices, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var list = new SurveyModel
                    {
                        ParkName = (string)reader["parkname"],
                        ParkCode = (string)reader["parkcode"]

                    };
                    allparks.Add(list);
                }
            }

            return allparks;
        }

        public IDictionary<string, string> DropDownParks()
        {
            IDictionary<string, string> dropdowns = new Dictionary<string, string>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_DisplayParkChoices, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var list = new SurveyModel
                    {
                        ParkName = (string)reader["parkname"],
                        ParkCode = (string)reader["parkcode"]
                    };
                    dropdowns.Add(list.ParkName,list.ParkCode);
                    
                }
            }

            return dropdowns;
        }
    }
}

    

