using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo_efcore.Models.Configurations
{
   public class GradeConfiguration : IEntityTypeConfiguration<Grade>
   {
      public void Configure(EntityTypeBuilder<Grade> builder)
      {
         builder.HasKey(m => m.GradeId);
         builder
            .HasOne(m => m.Student)
            .WithMany(m => m.Grades)
            .HasForeignKey(m => m.StudentId);
      }
   }
}