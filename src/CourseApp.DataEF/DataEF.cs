using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesApp.DataEF
{
    public class DataEF
    {
        protected internal ApplicationDBContext Context;
        public DataEF()
        {
            Context = new ApplicationDBContext();
        }
    }
}
