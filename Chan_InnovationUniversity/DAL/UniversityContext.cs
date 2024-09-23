using Chan_InnovationUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
namespace Chan_InnovationUniversity.DAL
{
    public class UniversityContext : DbContext
    {

        public UniversityContext() : base("name=UniversityContext")
        {
            this.Database.CommandTimeout = 15000;
        }

        public static UniversityContext Create()
        {
            return new UniversityContext();
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}