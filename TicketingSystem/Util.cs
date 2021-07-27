using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem
{
    public static class Util
    {
        public static String getConnStr()
        {
             //return System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
             return System.Configuration.ConfigurationManager.ConnectionStrings[0].ConnectionString.ToString();
            //  string sqlDataSource = _Configuration.GetConnectionString("EmployeeAppCon");
        }
    }
}
