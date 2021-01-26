using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApp.Entity
{
    public class StudentFactory : IStudentFactory
    {
        private IStudentRepository StudentRepo { get; set; }
        public StudentFactory(IStudentRepository pStudentRepo)
        {
            StudentRepo = pStudentRepo;
        }
        public CStudent CreateNew()
        {
            throw new NotImplementedException();
        }

        public List<CStudent> List()
        {
            throw new NotImplementedException();
        }
    }
    public interface IStudentFactory
    {
        CStudent CreateNew();
        List<CStudent> List();
    }
}
