using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursesApp.Entity
{
    [Table("Student")]
    public class CStudent
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [NotMapped]
        public int CourseCount { get; set; }
        public CStudent()
        {
        }
        public CStudent(int _Id, string _Name, int _CourseCount)
        {
            Id = _Id;
            Name = _Name;
            CourseCount = _CourseCount;
        }
    }
    public interface IStudentRepository
    {
        List<CStudent> List();
    }
}
