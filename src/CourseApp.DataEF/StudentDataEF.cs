using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesApp.Entity;

namespace CoursesApp.DataEF
{
    public class StudentDataEF: DataEF
    {
        public List<CStudent> List()
        {
            try
            {
                var studentList = Context.Students.ToList();
                
                return studentList;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
