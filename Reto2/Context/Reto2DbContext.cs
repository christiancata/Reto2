using Microsoft.EntityFrameworkCore;
using Reto2.Models;

namespace Reto2.Context
{
    public class Reto2DbContext : DbContext
    {
        #region Constructores
        public Reto2DbContext() { }
        public Reto2DbContext(DbContextOptions<Reto2DbContext> options) : base(options)
        {

        }
        #endregion
        #region Propiedades
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<SubjectProgram> SubjectProgram { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        #endregion
    }
}