using CoursesApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApp.Data
{
    public class StudentData : Data
    {
        public StudentData() : base()
        {

        }

        public List<CStudent> List()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sp = "sp_Student_List";
                command = new SqlCommand(sp, connection);
                dataReader = command.ExecuteReader();

                List<CStudent> result = new List<CStudent>();
                while (dataReader.Read())
                {
                    int id = dataReader.GetFieldValue<int>(0);
                    string name = dataReader.GetFieldValue<string>(1);
                    int coursecount = dataReader.GetFieldValue<int>(2);
                    CStudent item = new CStudent(id, name, coursecount);
                    result.Add(item);
                }
                connection.Close();
                return result;
            }
        }
    }
}
