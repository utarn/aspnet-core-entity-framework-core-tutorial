namespace demo_efcore.Models
{
   public class Grade
   {
      public int GradeId { get; set; }
      public string GradeName { get; set; }
      public string Section { get; set; }
      public Student Student { get; set; }
      public int StudentId { get; set; }
   }
}