using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo_efcore.Models.Configurations
{
   public class StudentConfiguration : IEntityTypeConfiguration<Student>
   {
      public void Configure(EntityTypeBuilder<Student> builder)
      {
         builder.HasKey(m => m.Id);
         //  builder
         //     .HasMany(m => m.Grades)
         //     .WithOne(m => m.Student)
         //     .HasForeignKey(m => m.StudentId);

         builder
            .HasOne(m => m.StudentAddress)
            .WithOne(m => m.Student)
            .HasForeignKey<StudentAddress>(m => m.StudentId);
      }
   }
}