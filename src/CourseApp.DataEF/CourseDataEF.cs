using CoursesApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApp.DataEF
{
    public class CourseDataEF : DataEF
    {
        public List<CCourse> List()
        {
            try
            {
                return Context.Courses.ToList();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public bool Save(CCourse value)
        {
            
            var row = Context.Courses.FirstOrDefault(x => x.Id == value.Id);
            if (row != null)
            {
                Context.Entry(row).CurrentValues.SetValues(value);
            }
            else
            {
                Context.Courses.Add(value);
            }
            return Context.SaveChanges()>0;
        }
    }
}
