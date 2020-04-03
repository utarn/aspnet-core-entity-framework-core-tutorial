using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo_efcore.Models.Configurations
{
   public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
   {
      public void Configure(EntityTypeBuilder<Registration> builder)
      {
         builder.HasKey(m => new { m.StudentId, m.CourseId });
         builder.HasIndex(m => m.CourseId);
         builder
            .HasOne(m => m.Student)
            .WithMany(m => m.Registrations)
            .HasForeignKey(m => m.StudentId);
         builder
             .HasOne(m => m.Course)
             .WithMany()
             .HasForeignKey(m => m.CourseId);
      }
   }
}