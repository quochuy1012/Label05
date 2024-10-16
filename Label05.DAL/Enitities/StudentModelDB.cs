using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Label05.DAL.Enitities
{
    public partial class StudentModelDB : DbContext
    {
        public StudentModelDB()
            : base("name=StudentModelDB")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Majors)
                .WithRequired(e => e.Faculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Major>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Major)
                .HasForeignKey(e => new { e.FacultyID, e.MajorID });
        }
    }
}
