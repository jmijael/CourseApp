using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApp.Data
{
    public class Data
    {
        public string connectionString { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataReader dataReader { get; set; }

        public Data()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }
    }
}
