using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using demo_efcore.Models;
using demo_efcore.Models.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace demo_efcore.Data
{
   public class ApplicationDbContext : IdentityDbContext
   {
      public DbSet<Course> Courses { get; set; }
      public DbSet<Grade> Grades { get; set; }
      public DbSet<Student> Students { get; set; }
      public DbSet<StudentAddress> StudentAddresses { get; set; }
      public DbSet<Registration> Registrations { get; set; }
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
      {

      }

      // protected override void OnModelCreating(ModelBuilder builder)
      // {
      //    builder.Entity<Course>().HasKey(c => c.Id);
      // }

      protected override void OnModelCreating(ModelBuilder builder)
      {
         base.OnModelCreating(builder);
         builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
      }
   }
}
