using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CoursesApp.Entity;

namespace CoursesApp.DataEF
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("DBConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public DbSet<CStudent> Students { get; set; }
        public DbSet<CCourse> Courses { get; set; }
    }
}
