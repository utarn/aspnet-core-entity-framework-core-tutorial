namespace demo_efcore.Models
{
   public class StudentAddress
   {
      public int StudentAddressId { get; set; }
      public string Address { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string Country { get; set; }
      public Student Student { get; set; }
      public int StudentId { get; set; }
   }
}