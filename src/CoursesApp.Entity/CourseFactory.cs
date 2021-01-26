using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApp.Entity
{
    public class CourseFactory : ICourseFactory
    {
        private ICourseRepository CourseRepo { get; set; }
        public CourseFactory(ICourseRepository pCourseRepo)
        {
            CourseRepo = pCourseRepo;
        }
        public CCourse CreateNew()
        {
            return new CCourse();
        }

        public List<CCourse> List()
        {
            return CourseRepo.List();
        }

        public bool Save(CCourse value)
        {
            return CourseRepo.Save(value);
        }
    }
    public interface ICourseFactory
    {
        CCourse CreateNew();
        List<CCourse> List();
        bool Save(CCourse value);
    }
}
