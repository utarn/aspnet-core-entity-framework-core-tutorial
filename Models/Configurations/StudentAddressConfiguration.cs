using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo_efcore.Models.Configurations
{
   public class StudentAddressConfiguration : IEntityTypeConfiguration<StudentAddress>
   {
      public void Configure(EntityTypeBuilder<StudentAddress> builder)
      {
         builder.HasKey(m => m.StudentAddressId);

      }
   }
}