using CoursesApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CoursesApp.Data
{
    public class CourseData: Data,ICourseRepository
    {
        public CourseData() : base()
        {

        }

        public List<CCourse> List()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sp = "sp_Course_List";
                command = new SqlCommand(sp, connection);
                dataReader = command.ExecuteReader();

                List<CCourse> result = new List<CCourse>();
                while (dataReader.Read())
                {
                    int id = dataReader.GetFieldValue<int>(0);
                    string name = dataReader.GetFieldValue<string>(1);
                    CCourse item = new CCourse(id,name);
                    result.Add(item);
                }
                connection.Close();
                return result;
            }
        }
        public bool Save(CCourse value)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sp = string.Format("sp_Course_Save @Id = {0}, @Name = '{1}'",value.Id,value.Name);
                command = new SqlCommand(sp, connection);
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result>0;
            }
        }
    }
}
