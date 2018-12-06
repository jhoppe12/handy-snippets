using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public interface ISurveyDAL
    {
        IList<SurveyModel> DisplaySurveys();
        bool AddNewSurvey(SurveyModel survey);
        IList<SurveyModel> ParkPicks();
    }
}
