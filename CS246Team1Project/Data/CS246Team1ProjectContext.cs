using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CS246Team1Project.Models;

namespace CS246Team1Project.Data
{
    public class CS246Team1ProjectContext : DbContext
    {
        public CS246Team1ProjectContext (DbContextOptions<CS246Team1ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<StudentModel> StudentModel { get; set; } = default!;
        public DbSet<CourseGradeModel> CourseGradeModel { get; set; } = default!;
        public DbSet<CourseModel> CourseModel { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>(entity =>
            {
                entity.OwnsOne(s => s.Address);
                entity.HasMany(s => s.Courses)
                      .WithOne()
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<CourseModel>()
                .Property(c => c.Term)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

            base.OnModelCreating(modelBuilder);
        }
    }
}
