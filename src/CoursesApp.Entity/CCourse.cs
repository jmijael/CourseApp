using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApp.Entity
{
    public class CCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CCourse()
        {
        }
        public CCourse(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
        }
    }
}
