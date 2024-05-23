using EF_CodeFirstIsipitAntunVajdic.Models.Dbo.Common;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirstIsipitAntunVajdic.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "Marko Markic", DateOfBirth = new DateTime(1998, 2, 26), Height = 182.5m, Weight = 77.8f },
                new Student { StudentId = 2, StudentName = "Petar Petrovic", DateOfBirth = new DateTime(1995, 6, 10), Height = 190.5m, Weight = 85.0f },
                new Student { StudentId = 3, StudentName = "Danijel Radovac", DateOfBirth = new DateTime(1994, 9, 1), Height = 180.5m, Weight = 81.2f }

                );
            modelBuilder.Entity<Grade>().HasData(
                new Grade { GradeId = 1, GradeName = "P.E", Section = "B", StudentId = 1 },
                new Grade { GradeId = 2, GradeName = "Math", Section = "A", StudentId = 2 },
                new Grade { GradeId = 3, GradeName = "History", Section = "C", StudentId = 2 },
                new Grade { GradeId = 4, GradeName = "P.E", Section = "D", StudentId = 3 },
                new Grade { GradeId = 5, GradeName = "Chemistry", Section = "E", StudentId = 3 },
                new Grade { GradeId = 6, GradeName = "Chemistry", Section = "B", StudentId = 1 },
                new Grade { GradeId = 7, GradeName = "English", Section = "B", StudentId = 3 },
                new Grade { GradeId = 8, GradeName = "English", Section = "B", StudentId = 2 },
                new Grade { GradeId = 9, GradeName = "P.E", Section = "B", StudentId = 2 },
                new Grade { GradeId = 10, GradeName = "Math", Section = "B", StudentId = 1 }

                );

            base.OnModelCreating(modelBuilder);

        }







    }
}
