using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo_efcore.Models.Configurations
{
   public class CourseConfiguration : IEntityTypeConfiguration<Course>
   {
      public void Configure(EntityTypeBuilder<Course> builder)
      {
         builder.HasKey(m => m.Id);
         //  builder.Property(m => m.Name).IsRequired();
      }
   }
}