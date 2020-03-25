namespace demo_efcore.Models
{
   public class Course
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Year { get; set; }
      public bool IsAvailable { get; set; }
   }
}