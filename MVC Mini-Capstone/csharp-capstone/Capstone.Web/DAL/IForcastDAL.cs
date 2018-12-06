using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public interface IForcastDAL
    {
        IList<ForcastModel> GetForcast(string id);
        //IList<ForcastModel> GetForcast(string id);
    }
}
