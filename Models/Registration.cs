using System.ComponentModel.DataAnnotations;

namespace demo_efcore.Models
{
   public class Registration
   {
      public Student Student { get; set; }
      public int StudentId { get; set; }
      public Course Course { get; set; }
      public int CourseId { get; set; }
      public decimal Score { get; set; }
   }
}